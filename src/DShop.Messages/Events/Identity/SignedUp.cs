using System;

namespace DShop.Messages.Events.Identity
{
    public class SignedUp : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        protected SignedUp()
        {
        }

        public SignedUp(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}