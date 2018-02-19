using System;

namespace DShop.Messages.Events.Customers
{
    public class CustomerCreated : IEvent
    {
        public Guid RequestId { get; } 
        public Guid UserId { get;  }

        public CustomerCreated(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}