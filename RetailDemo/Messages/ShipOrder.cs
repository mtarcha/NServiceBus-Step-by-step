using System;
using NServiceBus;

namespace Messages
{
    public class ShipOrder : ICommand
    {
        public Guid Id { get; set; }
    }
}