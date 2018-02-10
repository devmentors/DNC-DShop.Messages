using System;

namespace DShop.Messages.Commands.Products
{
	public class EditProduct : ICommand
	{
		public Request Request { get; set; }
        public Guid Id { get; }
        public string Name { get; }
        public string Descirption { get; }
        public decimal Price { get; }
	}
}