using System;
using Newtonsoft.Json;

namespace DShop.Messages.Commands.Customers
{
    public class ClearCart : ICommand
    {
        public Guid UserId { get; }

        [JsonConstructor]
        public ClearCart(Guid userId)
        {
            UserId = userId;
        }
    }
}