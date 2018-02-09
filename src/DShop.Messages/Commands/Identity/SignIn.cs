using Newtonsoft.Json;

namespace DShop.Messages.Commands.Identity
{
    public class SignIn : ICommand
    {
        public Request Request { get; set; }
        public string Email { get; }
        public string Password { get; }

        [JsonConstructor]
        public SignIn(string email, string password)
        {
        }
    }
}