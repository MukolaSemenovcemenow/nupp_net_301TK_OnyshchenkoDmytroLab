using Lab1_0110Dplus.Models;
using Lab1_0110Dplus.Services;
using System;

namespace Lab1_0110Dplus
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PersonService();

            service.Add(new Person { Id = 1, Name = "Дмитро", Age = 20 });
            service.Add(new Person { Id = 2, Name = "Ольга", Age = 30 });

            Console.WriteLine("Дані до збереження:");
            foreach (var p in service.GetAll())
            {
                Console.WriteLine($"{p.Id}: {p.Name}, {p.Age}");
            }

            service.Save("people.json");

            Console.WriteLine("\nОчищено і завантажено з файлу:");
            service = new PersonService(); 
            service.Load("people.json");

            foreach (var p in service.GetAll())
            {
                Console.WriteLine($"{p.Id}: {p.Name}, {p.Age}");
            }

            Console.ReadKey();
        }
    }
}
