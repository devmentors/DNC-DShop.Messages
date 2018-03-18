using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class ProductDeletedFromCart : IEvent
    {
        public Guid CustomerId { get; }
        public Guid ProductId { get; }

        [JsonConstructor]
        public ProductDeletedFromCart(Guid customerId, Guid productId)
        {
            CustomerId = customerId;
            ProductId = productId;
        }        
    }
}