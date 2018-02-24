using Newtonsoft.Json;

namespace DShop.Messages.Commands.Identity
{
    public class SignIn : ICommand
    {
        public string Email { get; }
        public string Password { get; }

        [JsonConstructor]
        public SignIn(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}