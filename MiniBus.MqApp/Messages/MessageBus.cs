using Microsoft.Extensions.DependencyInjection;
using MiniBus.MqApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBus.MqApp.Messages
{
    public class MessageBus
    {

        private readonly IServiceProvider _provider;

        public MessageBus(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task Publish<T>(T message) where T : IMessage
        {
            var consumers = _provider.GetServices<IConsumer<T>>();

            foreach (var consumer in consumers)
            {
                await consumer.Consume(message);
            }
        }

    }
}
