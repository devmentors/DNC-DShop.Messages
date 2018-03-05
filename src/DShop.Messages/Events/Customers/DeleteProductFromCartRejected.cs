using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class DeleteProductFromCartRejected : IRejectedEvent
    {
        public Guid UserId { get; }
        public Guid ProductId { get; }
        public string Reason { get; }
        public string Code { get; }

        [JsonConstructor]
        public DeleteProductFromCartRejected(Guid userId, Guid productId,
            string reason, string code)
        {
            UserId = userId;
            ProductId = productId;
            Reason = reason;
            Code = code;
        }        
    }
}