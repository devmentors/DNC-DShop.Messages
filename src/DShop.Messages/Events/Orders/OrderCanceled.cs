using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Orders
{
    public class OrderCanceled : IEvent
    {
        public Guid Id { get; }
        public Guid CustomerId { get; }

        [JsonConstructor]
        public OrderCanceled(Guid id, Guid customerId)
        {
            Id = id;
            CustomerId = customerId;
        }
    }
}
