using MiniBus.MqApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBus.MqApp.Messages
{
    public class OrderSubmitted : IMessage
    {
        public Guid OrderId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}
