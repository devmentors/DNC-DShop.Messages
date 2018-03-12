using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Products
{
    public class ProductCreated : IEvent
    {
        public Guid Id { get; }

        [JsonConstructor]
        public ProductCreated(Guid id)
        {
            Id = id;
        }
    }
}
