using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBus.MqApp.Core
{
    public interface IMessage
    {
        public Guid Id { get; set; } //add an Id property to uniquely identify each message
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
