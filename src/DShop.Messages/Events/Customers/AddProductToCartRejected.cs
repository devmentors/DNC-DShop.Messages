using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class AddProductToCartRejected : IRejectedEvent
    {
        public Guid UserId { get; }
        public Guid ProductId { get; }
        public int Quantity { get; }
        public string Reason { get; }
        public string Code { get; }

        [JsonConstructor]
        public AddProductToCartRejected(Guid userId, Guid productId,
            int quantity, string reason, string code)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
            Reason = reason;
            Code = code;
        }
    }
}