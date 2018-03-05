using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class CustomerCreated : IEvent
    {
        public Guid UserId { get;  }

        [JsonConstructor]
        public CustomerCreated(Guid userId)
        {
            UserId = userId;
        }
    }
}