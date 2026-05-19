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

        private readonly IServiceProvider _provider;
        private readonly BlockingCollection<IMessage> _queue;

        public MessageBus(IServiceProvider provider)
        {
            _provider = provider;
            _queue = new BlockingCollection<IMessage>();
        }

        public async Task Publish<T>(T message) where T : IMessage
        {
            //var consumers = _provider.GetServices<IConsumer<T>>();

            //foreach (var consumer in consumers)
            //{
            //    await consumer.Consume(message);
            //}
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
