using Newtonsoft.Json;

namespace DShop.Messages.Commands.Identity
{
    public class SignUp
    {
        public string Email { get; }
        public string Password { get; }

        [JsonConstructor]
        public SignUp(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}