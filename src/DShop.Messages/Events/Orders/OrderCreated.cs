using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Orders
{
    public class OrderCreated : IEvent
    {
        public Guid Id { get; }

        [JsonConstructor]
        public OrderCreated(Guid id)
        {
            Id = id;
        }
    }
}
