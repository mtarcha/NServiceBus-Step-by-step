using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;

namespace Sales
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public async Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            Console.WriteLine("Place order with id:" + message.Id);

            await context.Publish<OrderPlaced>(x => x.Id = message.Id);
        }
    }
}