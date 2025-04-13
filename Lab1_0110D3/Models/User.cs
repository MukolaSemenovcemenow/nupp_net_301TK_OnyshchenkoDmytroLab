using System;

namespace Lab1_0110D3.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public override string ToString()
        {
            return $"User: {Name}, ID: {Id}";
        }
    }
}
