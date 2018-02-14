using System;

namespace DShop.Messages.ReadModels
{
    public class ProductDetailsReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descirption { get; set; }
        public string Vendor { get; set; }
        public decimal Price { get; set; }
    }
}
