using System;

namespace DShop.Messages.Events
{
    public interface IEvent
    {
        Guid RequestId { get; }
        Guid UserId { get; }
    }
}