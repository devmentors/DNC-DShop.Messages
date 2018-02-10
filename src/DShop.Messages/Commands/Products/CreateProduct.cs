namespace DShop.Messages.Commands.Products
{
	public class CreateProduct : ICommand
	{
		public Request Request { get; set; }
        public string Name { get; }
        public string Descirption { get; }
        public string Vendor { get; }
        public decimal Price { get; }
	}
}