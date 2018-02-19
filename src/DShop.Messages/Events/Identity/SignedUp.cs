using System;

namespace DShop.Messages.Events.Identity
{
    public class SignedUp : IEvent
    {
        public Guid RequestId { get; }
        public Guid UserId { get; }
        public string Email { get; }

        protected SignedUp()
        {
        }

        public SignedUp(Guid requestId, Guid userId,
            string email)
        {
            RequestId = requestId;
            UserId = userId;
            Email = email;
        }
    }
}