using System;
using NServiceBus;

namespace Messages
{
    public class OrderPlaced : IEvent
    {
        public Guid Id { get; set; }
    }
}