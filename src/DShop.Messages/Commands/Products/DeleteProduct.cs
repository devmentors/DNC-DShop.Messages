using System;

namespace DShop.Messages.Commands.Products
{
	public class DeleteProduct : ICommand
	{
		public Request Request { get; set; }
        public Guid Id { get; }
	}
}