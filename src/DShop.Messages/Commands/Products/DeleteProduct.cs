using Newtonsoft.Json;
using System;

namespace DShop.Messages.Commands.Products
{
	public class DeleteProduct : ICommand
	{
        public Guid Id { get; }

        [JsonConstructor]
        public DeleteProduct(Guid id)
        {
            Id = id;
        }
	}
}