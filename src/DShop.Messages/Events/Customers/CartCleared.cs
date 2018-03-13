using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class CartCleared : IEvent
    {
        public Guid UserId { get;  }

        [JsonConstructor]
        public CartCleared(Guid userId)
        {
            UserId = userId;
        }
    }
}