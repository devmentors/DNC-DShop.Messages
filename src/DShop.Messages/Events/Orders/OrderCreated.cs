using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Orders
{
    public class OrderCreated : IEvent
    {
        public Guid Id { get; }
        public Guid CustomerId { get; }
        public long Number { get; }

        [JsonConstructor]
        public OrderCreated(Guid id, Guid customerId, long number)
        {
            Id = id;
            CustomerId = customerId;
            Number = number;
        }
    }
}
