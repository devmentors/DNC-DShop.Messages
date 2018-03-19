using Newtonsoft.Json;

namespace DShop.Messages.Commands.Identity
{
    public class SignUp
    {
        public string Email { get; }
        public string Password { get; }
        public string Role { get; }

        [JsonConstructor]
        public SignUp(string email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;
        }
    }
}