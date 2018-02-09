using System;

namespace DShop.Messages.Events.Identity
{
    public class SignedIn : IEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        protected SignedIn()
        {
        }

        public SignedIn(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}