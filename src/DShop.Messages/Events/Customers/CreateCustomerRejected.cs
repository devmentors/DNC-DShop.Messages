using System;
using Newtonsoft.Json;

namespace DShop.Messages.Events.Customers
{
    public class CreateCustomerRejected : IRejectedEvent
    {
        public Guid UserId { get; }
        public string Reason { get; }
        public string Code { get; }

        [JsonConstructor]
        public CreateCustomerRejected(Guid userId, string reason, string code)
        {
            UserId = userId;
            Reason = reason;
            Code = code;
        }
    }
}