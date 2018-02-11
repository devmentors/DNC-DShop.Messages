using System;

namespace DShop.Messages.Commands.Products
{
	public class DeleteProduct : ICommand
	{
        public Guid Id { get; }
	}
}