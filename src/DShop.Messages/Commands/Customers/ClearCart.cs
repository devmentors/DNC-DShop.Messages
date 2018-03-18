using System;
using Newtonsoft.Json;

namespace DShop.Messages.Commands.Customers
{
    public class ClearCart : ICommand
    {
        public Guid CustomerId { get; }

        [JsonConstructor]
        public ClearCart(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}