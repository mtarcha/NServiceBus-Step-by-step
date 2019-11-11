using System;
using NServiceBus;

namespace Messages
{
    public class OrderBilled : IEvent
    {
        public Guid Id { get; set; }
    }
}