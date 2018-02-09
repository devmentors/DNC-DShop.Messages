using System.Threading.Tasks;

namespace DShop.Messages.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}