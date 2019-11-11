using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;

namespace Billing
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public async Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            Console.WriteLine($"Order billed {message.Id}");

            await context.Publish<OrderBilled>(x => x.Id = message.Id);
        }
    }
}