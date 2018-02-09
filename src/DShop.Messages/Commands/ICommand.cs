namespace DShop.Messages.Commands
{
    public interface ICommand
    {
        Request Request { get; set; }
    }
}