using Newtonsoft.Json;
using System;

namespace DShop.Messages.Commands.Orders
{
    public class CancelOrder : ICommand
    {
        public Guid Id { get; }

        [JsonConstructor]
        private CancelOrder()
        {
            Id = Id;
        }
    }
}
