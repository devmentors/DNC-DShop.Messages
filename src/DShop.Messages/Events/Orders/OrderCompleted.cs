using System;

namespace DShop.Messages.Events.Orders
{
    public class OrderCompleted : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        public OrderCompleted(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
