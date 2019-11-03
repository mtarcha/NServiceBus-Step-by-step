using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;

namespace ClientUI
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            Console.WriteLine("Place order with id:" + message.Id);

            return Task.CompletedTask;
        }
    }
}