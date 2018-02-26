using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Identity
{
    public class SignedUp : IEvent
    {
        public Guid RequestId { get; }
        public Guid UserId { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }

        protected SignedUp()
        {
        }

        [JsonConstructor]
        public SignedUp(Guid requestId, Guid userId, string email, 
            string firstName, string lastName, string address)
        {
            RequestId = requestId;
            UserId = userId;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}