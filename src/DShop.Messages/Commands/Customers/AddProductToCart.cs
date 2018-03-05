using System;
using Newtonsoft.Json;

namespace DShop.Messages.Commands.Customers
{
    public class AddProductToCart : ICommand
    {
        public Guid UserId { get; }
        public Guid ProductId { get; }
        public int Quantity { get; }

        [JsonConstructor]
        public AddProductToCart(Guid userId, Guid productId,
            int quantity)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}