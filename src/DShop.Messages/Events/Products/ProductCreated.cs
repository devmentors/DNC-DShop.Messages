using System;

namespace DShop.Messages.Events.Products
{
    public class ProductCreated : IEvent
    {
        public Guid RequestId { get; } 

        public Guid UserId { get;  }

        public ProductCreated(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
