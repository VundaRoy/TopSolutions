using MiniBus.MqApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBus.MqApp.Consumers
{
    public class OrderSubmittedConsumer : IConsumer<OrderSubmitted>
    {
        public Task Consume(OrderSubmitted message)
        {
            Console.WriteLine($"Order submitted: {message.OrderId}");
            return Task.CompletedTask;
        }
    }
}
