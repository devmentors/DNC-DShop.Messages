using System;

namespace DShop.Messages.Events.Orders
{
    public class OrderCanceled : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        public OrderCanceled(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}
