using Microsoft.Extensions.DependencyInjection;
using MiniBus.MqApp.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBus.MqApp.Messages
{
    public class MessageBus
    {

        private readonly IServiceProvider _provider; //inject the service provider to resolve consumers when dispatching messages
        private readonly BlockingCollection<IMessage> _queue; //use a thread-safe collection to hold messages for processing in the background
        private readonly RetryExecutor _retry; //use the retry executor to handle retries when processing messages

        public MessageBus(IServiceProvider provider, RetryExecutor retry) //inject the retry executor to handle retries when processing messages
        {
            _provider = provider;
            _queue = new BlockingCollection<IMessage>();
            _retry = retry;
        }

        public async Task Publish<T>(T message) where T : IMessage
        {            
            _queue.Add(message); //enqueue the message for processing instead of processing it immediately
        }

        public void Start()
        {
            Task.Run(() =>
            {
                foreach (var message in _queue.GetConsumingEnumerable())
                {
                    Dispatch(message);
                }
            });
        }

        private void Dispatch(IMessage message)
        {
            var messageType = message.GetType();
            var consumerType = typeof(IConsumer<>).MakeGenericType(messageType);

            var consumers = _provider.GetServices(consumerType);

            foreach (var consumer in consumers)
            {
                var method = consumerType.GetMethod("Consume");
                method.Invoke(consumer, new object[] { message });
            }
        }

    }
}
