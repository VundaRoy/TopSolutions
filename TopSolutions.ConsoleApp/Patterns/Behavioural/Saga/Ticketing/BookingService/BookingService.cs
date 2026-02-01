using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.DomainEvents;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.EventInfrastructure;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.StateManagement;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.BookingService
{
    public class BookingService //: IEventHandler
    {
        private readonly ISagaStateRepository _stateRepository;
        private readonly IEventBus _eventBus;
        private readonly ILogger<BookingService> _logger;

        public BookingService(
            ISagaStateRepository stateRepository,
            IEventBus eventBus,
            ILogger<BookingService> logger)
        {
            _stateRepository = stateRepository;
            _eventBus = eventBus;
            _logger = logger;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _eventBus.SubscribeAsync<BookingInitiatedEvent>(Handle);
            _eventBus.SubscribeAsync<CustomerValidatedEvent>(Handle);
            _eventBus.SubscribeAsync<CustomerValidationFailedEvent>(Handle);
            _eventBus.SubscribeAsync<PaymentProcessedEvent>(Handle);
            _eventBus.SubscribeAsync<PaymentFailedEvent>(Handle);
            _eventBus.SubscribeAsync<InventoryReservedEvent>(Handle);
            _eventBus.SubscribeAsync<InventoryReservationFailedEvent>(Handle);
        }

        public async Task<Guid> InitiateBookingAsync(Guid customerId, Guid bookId, decimal amount, int quantity)
        {
            var correlationId = Guid.NewGuid();
            var bookingId = Guid.NewGuid();

            var state = new BookingState
            {
                BookingId = bookingId,
                CorrelationId = correlationId,
                Status = SagaStatus.Started,
                CustomerId = customerId,
                BookId = bookId,
                Amount = amount,
                Quantity = quantity,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _stateRepository.SaveStateAsync(state);

            var initiatedEvent = new BookingInitiatedEvent
            {
                CorrelationId = correlationId,
                BookingId = bookingId,
                CustomerId = customerId,
                BookId = bookId,
                Amount = amount,
                Quantity = quantity
            };

            await _eventBus.PublishAsync(initiatedEvent);
            _logger.LogInformation("Booking saga initiated: {CorrelationId}", correlationId);

            return correlationId;
        }

        public async Task Handle(BookingInitiatedEvent @event)
        {
            // Trigger customer validation
            var validationEvent = new CustomerValidationRequestEvent
            {
                CorrelationId = @event.CorrelationId,
                CustomerId = @event.CustomerId,
                BookingId = @event.BookingId
            };

            await _eventBus.PublishAsync(validationEvent);
        }

        public async Task Handle(CustomerValidatedEvent @event)
        {
            var state = await _stateRepository.GetStateAsync(@event.CorrelationId);
            state.Status = SagaStatus.CustomerValidated;
            state.UpdatedAt = DateTime.UtcNow;
            await _stateRepository.UpdateStateAsync(state);

            // Trigger payment processing
            var paymentEvent = new PaymentRequestEvent
            {
                CorrelationId = @event.CorrelationId,
                BookingId = @event.BookingId,
                CustomerId = @event.CustomerId,
                Amount = state.Amount
            };

            await _eventBus.PublishAsync(paymentEvent);
        }

        public async Task Handle(CustomerValidationFailedEvent @event)
        {
            await HandleFailure(@event.CorrelationId, @event.Reason);
        }

        public async Task Handle(PaymentProcessedEvent @event)
        {
            var state = await _stateRepository.GetStateAsync(@event.CorrelationId);
            state.Status = SagaStatus.PaymentProcessed;
            state.PaymentId = @event.CorrelationId;
            state.UpdatedAt = DateTime.UtcNow;
            await _stateRepository.UpdateStateAsync(state);

            // Trigger inventory reservation
            var inventoryEvent = new InventoryReservationRequestedEvent
            {
                CorrelationId = @event.CorrelationId,
                BookingId = @event.BookingId,
                BookId = state.BookId,
                Quantity = state.Quantity
            };

            await _eventBus.PublishAsync(inventoryEvent);
        }

        public async Task Handle(PaymentFailedEvent @event)
        {
            await HandleFailure(@event.CorrelationId, @event.Reason);
        }

        public async Task Handle(InventoryReservedEvent @event)
        {
            var state = await _stateRepository.GetStateAsync(@event.CorrelationId);
            state.Status = SagaStatus.InventoryReserved;
            state.UpdatedAt = DateTime.UtcNow;
            await _stateRepository.UpdateStateAsync(state);

            // Complete the saga
            await CompleteBooking(@event.CorrelationId);
        }

        public async Task Handle(InventoryReservationFailedEvent @event)
        {
            var state = await _stateRepository.GetStateAsync(@event.CorrelationId);

            // Start compensation - refund payment
            if (state.PaymentId.HasValue)
            {
                state.Status = SagaStatus.Compensating;
                await _stateRepository.UpdateStateAsync(state);

                var refundEvent = new PaymentRefundedEvent
                {
                    CorrelationId = @event.CorrelationId,
                    BookingId = @event.BookingId,
                    CustomerId = state.PaymentId.Value
                };

                await _eventBus.PublishAsync(refundEvent);
            }

            await HandleFailure(@event.CorrelationId, @event.Reason);
        }

        private async Task CompleteBooking(Guid correlationId)
        {
            var state = await _stateRepository.GetStateAsync(correlationId);
            state.Status = SagaStatus.Completed;
            state.UpdatedAt = DateTime.UtcNow;
            await _stateRepository.UpdateStateAsync(state);

            var confirmedEvent = new BookingConfirmedEvent
            {
                CorrelationId = correlationId,
                BookingId = state.BookingId,
                CustomerId = state.CustomerId
            };

            await _eventBus.PublishAsync(confirmedEvent);
            _logger.LogInformation("Booking saga completed: {CorrelationId}", correlationId);
        }

        private async Task HandleFailure(Guid correlationId, string reason)
        {
            var state = await _stateRepository.GetStateAsync(correlationId);
            state.Status = SagaStatus.Failed;
            state.FailureReason = reason;
            state.UpdatedAt = DateTime.UtcNow;
            await _stateRepository.UpdateStateAsync(state);

            var failedEvent = new BookingFailedEvent
            {
                CorrelationId = correlationId,
                BookingId = state.BookingId,
                CustomerId = state.CustomerId,
                Reason = reason
            };

            await _eventBus.PublishAsync(failedEvent);
            _logger.LogWarning("Booking saga failed: {CorrelationId}, Reason: {Reason}", correlationId, reason);
        }
    }

}
