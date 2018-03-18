using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class CustomerCreated : IEvent
    {
        public Guid Id { get;  }

        [JsonConstructor]
        public CustomerCreated(Guid id)
        {
            Id = id;
        }
    }
}