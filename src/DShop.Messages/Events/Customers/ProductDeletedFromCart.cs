using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class ProductDeletedFromCart : IEvent
    {
        public Guid UserId { get; }
        public Guid ProductId { get; }

        [JsonConstructor]
        public ProductDeletedFromCart(Guid userId, Guid productId)
        {
            UserId = userId;
            ProductId = productId;
        }        
    }
}