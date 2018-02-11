using System;

namespace DShop.Messages.Entities
{
    public interface IEntity
    {
         Guid Id { get; }
         DateTime CreatedDate { get; }
         DateTime UpdatedDate { get; }
    }
}