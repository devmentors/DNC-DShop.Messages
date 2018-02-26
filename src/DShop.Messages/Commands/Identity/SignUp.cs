using Newtonsoft.Json;

namespace DShop.Messages.Commands.Identity
{
    public class SignUp
    {
        public string Email { get; }
        public string Password { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }

        [JsonConstructor]
        public SignUp(string email, string password, 
            string firstName, string lastName, string address)
        {
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}