using System;

namespace DShop.Messages.Events.Products
{
    public class ProductDeleted : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; set; }

        public ProductDeleted(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
