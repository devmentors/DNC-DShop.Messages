using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Orders
{
    public class OrderCompleted : IEvent
    {
        public Guid Id { get; }

        [JsonConstructor]
        public OrderCompleted(Guid id)
        {
            Id = id;
        }
    }
}
