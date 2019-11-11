using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;

namespace Shipping
{
    class ShipOrderHandler : IHandleMessages<ShipOrder>
    {
        public Task Handle(ShipOrder message, IMessageHandlerContext context)
        {
            Console.WriteLine($"Order [{message.Id}] - Successfully shipped.");

            return Task.CompletedTask;
        }
    }
}