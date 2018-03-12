using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Orders
{
    public class OrderCanceled : IEvent
    {
        public Guid Id { get; }

        [JsonConstructor]
        public OrderCanceled(Guid id)
        {
            Id = id;
        }
    }
}
