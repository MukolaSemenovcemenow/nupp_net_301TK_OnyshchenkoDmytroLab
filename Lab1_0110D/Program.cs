using System;
using Lab1_0110D.Common;

namespace Lab1_0110D
{
    class Program
    {
        static void Main(string[] args)
        {
            Device[] devices = new Device[]
            {
                new Smartphone("iPhone 13", 30000, "iOS"),
                new Laptop("Dell XPS 13", 45000, "Intel i7"),
                new Charger("Baseus 65W", 1500, 65),
                new Accessory("Logitech Mouse", 700, "Мишка")
            };

            foreach (Device device in devices)
            {
                device.PrintInfo();
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
