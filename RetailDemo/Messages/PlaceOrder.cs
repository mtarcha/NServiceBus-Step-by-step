using System;
using NServiceBus;

namespace Messages
{
    public class PlaceOrder : ICommand
    {
        public Guid Id { get; set; }
    }
}