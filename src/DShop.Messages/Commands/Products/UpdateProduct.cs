using System;

namespace DShop.Messages.Commands.Products
{
	public class UpdateProduct : ICommand
	{
        public Guid Id { get; }
        public string Name { get; }
        public string Descirption { get; }
        public decimal Price { get; }
	}
}