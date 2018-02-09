using System;
using System.Linq;

namespace DShop.Messages.Commands
{
    public class Request
    {
        public Guid Id { get; }
        public Guid UserId { get; }
        public Guid ResourceId { get; }
        public string Name { get; }
        public string Origin { get; }
        public string Resource { get; }
        public string Culture { get; }
        public DateTime CreatedAt { get; }

        protected Request()
        {
        }

        public Request(Guid id, Guid userId, Guid resourceId, string name, 
            string origin, string culture, string resource)
        {
            Id = id;
            UserId = userId;
            ResourceId = resourceId;
            Name = GetName(name);
            Origin = origin.StartsWith("/") ? origin.Remove(0, 1) : origin;
            Culture = culture;
            Resource = resource;
            CreatedAt = DateTime.UtcNow;       
        }

        public static Request From<T>(Request request)
            => Create<T>(request.Id, request.UserId, request.ResourceId, request.Origin, request.Culture, request.Resource);

        public static Request Create<T>(Guid id, Guid userId, Guid resourceId, string origin, string culture, string resource = "")
            => new Request(id, userId, resourceId, typeof(T).Name, origin, culture, resource);

        private static string GetName(string name)
            => Underscore(name).ToLowerInvariant();

        private static string Underscore(string value)
            => string.Concat(value.Select((x,i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())); 
    }
}