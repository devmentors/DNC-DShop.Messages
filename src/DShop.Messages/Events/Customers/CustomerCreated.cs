using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class CustomerCreated : IEvent
    {
        public Guid RequestId { get; } 
        public Guid UserId { get;  }

        protected CustomerCreated()
        {           
        }    
        
        [JsonConstructor]
        public CustomerCreated(Guid requestId, Guid userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}