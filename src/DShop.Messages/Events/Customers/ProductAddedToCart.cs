using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class ProductAddedToCart : IEvent
    {
        public Guid UserId { get; }
        public Guid ProductId { get; }
        public int Quantity { get; }

        [JsonConstructor]
        public ProductAddedToCart(Guid userId, Guid productId,
            int quantity)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
        }        
    }
}