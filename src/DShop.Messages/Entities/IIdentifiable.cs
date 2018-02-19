using System;

namespace DShop.Messages.Entities
{
    public interface IIdentifiable
    {
         Guid Id { get; }
    }
}