namespace Lab1_0110D.Common
{
    public class Smartphone : Device
    {
        public string OS { get; set; }

        public Smartphone(string name, double price, string os) : base(name, price)
        {
            OS = os;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.WriteLine($"ОС: {OS}");
        }
    }
}
