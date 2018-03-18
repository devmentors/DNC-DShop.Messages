using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class CartCleared : IEvent
    {
        public Guid CustomerId { get;  }

        [JsonConstructor]
        public CartCleared(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}