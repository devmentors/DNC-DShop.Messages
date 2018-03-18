using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class ClearCartRejected : IRejectedEvent
    {
        public Guid CustomerId { get; }
        public string Reason { get; }
        public string Code { get; }

        [JsonConstructor]
        public ClearCartRejected(Guid customerId, string reason, string code)
        {
            CustomerId = customerId;
            Reason = reason;
            Code = code;
        }
    }
}