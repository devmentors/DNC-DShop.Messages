using System;
using Newtonsoft.Json;

namespace DShop.Messages.Commands.Customers
{
    public class DeleteProductFromCart : ICommand
    {
        public Guid UserId { get; }
        public Guid ProductId { get; }

        [JsonConstructor]
        public DeleteProductFromCart(Guid userId, Guid productId)
        {
            UserId = userId;
            ProductId = productId;
        }
    }
}