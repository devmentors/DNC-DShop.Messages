using System;

namespace DShop.Messages.Events.Products
{
    public class ProductUpdated : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; set; }

        public ProductUpdated(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
