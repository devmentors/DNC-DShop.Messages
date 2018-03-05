using System;
using Newtonsoft.Json;

namespace DShop.Messages.Commands.Customers
{
    public class CreateCustomer
    {
        public Guid UserId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string Country { get; }

        [JsonConstructor]
        public CreateCustomer(Guid userId, string firstName, string lastName, 
            string address, string country)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Country = country;
        }        
    }
}