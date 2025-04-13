using System;
using Lab1_0110D3.Models;
using Lab1_0110D3.Services;

namespace Lab1_0110D3
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new CrudService<User>();
            var user1 = new User { Name = "Дмитро" };
            userService.Create(user1);

            var user2 = new User { Name = "Ольга" };
            userService.Create(user2);

            Console.WriteLine("Список користувачів:");
            foreach (var user in userService.ReadAll())
            {
                Console.WriteLine(user);
            }

            user1.Name = "Дмитро Леонідович";
            userService.Update(user1);

            Console.WriteLine("\nПісля оновлення:");
            foreach (var user in userService.ReadAll())
            {
                Console.WriteLine(user);
            }

            userService.Remove(user2);

            Console.WriteLine("\nПісля видалення Ольги:");
            foreach (var user in userService.ReadAll())
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}