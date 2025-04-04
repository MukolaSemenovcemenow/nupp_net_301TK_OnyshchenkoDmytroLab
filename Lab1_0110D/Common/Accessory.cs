namespace Lab1_0110D.Common
{
    public class Accessory : Device
    {
        public string Type { get; set; }

        public Accessory(string name, double price, string type) : base(name, price)
        {
            Type = type;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.WriteLine($"Тип аксесуара: {Type}");
        }
    }
}
