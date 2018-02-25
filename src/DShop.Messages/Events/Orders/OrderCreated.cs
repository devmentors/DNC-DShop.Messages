using System;

namespace DShop.Messages.Events.Orders
{
    public class OrderCreated : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        public OrderCreated(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
