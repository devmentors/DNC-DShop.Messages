using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DShop.Messages.Commands.Orders
{
    public class CreateOrder : ICommand
    {
        public Guid Id { get; }
        public Guid CustomerId { get; }
        public long Number { get; }
        public IEnumerable<Guid> ProductIds { get; }
        public decimal TotalAmount { get; }

        [JsonConstructor]
        private CreateOrder(Guid id, Guid customerId, long number, IEnumerable<Guid> productIds, decimal totalAmount)
        {
            Id = id;
            CustomerId = customerId;
            Number = number;
            ProductIds = productIds;
            TotalAmount = totalAmount;
        }
    }
}
