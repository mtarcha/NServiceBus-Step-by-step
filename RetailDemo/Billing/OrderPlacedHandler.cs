using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;

namespace Billing
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            Console.WriteLine($"Order placed {message.Id}");

            return Task.CompletedTask;
        }
    }
}