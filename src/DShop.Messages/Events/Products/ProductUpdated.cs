using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Products
{
    public class ProductUpdated : IEvent
    {
        public Guid Id { get; }

        [JsonConstructor]
        public ProductUpdated(Guid id)
        {
            Id = id;
        }
    }
}
