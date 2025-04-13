using System;
using Lab1_0110D4.Models;
using Lab1_0110D4.Services;

namespace Lab1_0110D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var passengerService = new CrudService<Passenger>();

            var p1 = new Passenger { FullName = "Дмитро Онищенко", TicketNumber = "P0110" };
            var p2 = new Passenger { FullName = "Ольга Крощенко", TicketNumber = "P0111" };

            passengerService.Create(p1);
            passengerService.Create(p2);

            Console.WriteLine("=== Список пасажирів ===");
            foreach (var p in passengerService.ReadAll())
            {
                Console.WriteLine(p);
            }

            p1.FullName = "Онищенко Дмитро Леонідович";
            passengerService.Update(p1);

            Console.WriteLine("\n=== Після оновлення ===");
            foreach (var p in passengerService.ReadAll())
            {
                Console.WriteLine(p);
            }

            passengerService.Remove(p2);

            Console.WriteLine("\n=== Після видалення ===");
            foreach (var p in passengerService.ReadAll())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
