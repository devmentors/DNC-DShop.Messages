using Newtonsoft.Json;
using System;

namespace DShop.Messages.Commands.Orders
{
    public class CompleteOrder : ICommand
    {
        public Guid Id { get; }

        [JsonConstructor]
        private CompleteOrder()
        {
            Id = Id;
        }
    }
}
