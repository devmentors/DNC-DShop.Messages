using System;

namespace DShop.Messages.Entities
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}