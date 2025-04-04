namespace Lab1_0110D.Common
{
    public class Laptop : Device
    {
        public string Processor { get; set; }

        public Laptop(string name, double price, string processor) : base(name, price)
        {
            Processor = processor;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.WriteLine($"Процесор: {Processor}");
        }
    }
}
