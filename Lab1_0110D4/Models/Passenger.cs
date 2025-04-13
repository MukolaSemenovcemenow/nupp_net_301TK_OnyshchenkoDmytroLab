using System;

namespace Lab1_0110D4.Models
{
    public class Passenger : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string TicketNumber { get; set; }

        public override string ToString()
        {
            return $"Пасажир: {FullName}, Квиток: {TicketNumber}, ID: {Id}";
        }
    }
}
