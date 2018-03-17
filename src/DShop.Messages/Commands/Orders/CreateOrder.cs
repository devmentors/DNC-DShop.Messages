using Newtonsoft.Json;
using System;

namespace DShop.Messages.Commands.Orders
{
    public class CreateOrder : ICommand
    {
        public Guid Id { get; }
        public Guid CustomerId { get; }

        [JsonConstructor]
        private CreateOrder(Guid id, Guid customerId)
        {
            Id = id;
            CustomerId = customerId;
        }
    }
}
