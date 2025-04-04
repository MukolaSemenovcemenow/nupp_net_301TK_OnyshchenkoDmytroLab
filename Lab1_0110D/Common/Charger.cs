namespace Lab1_0110D.Common
{
    public class Charger : Device
    {
        public int Power { get; set; }

        public Charger(string name, double price, int power) : base(name, price)
        {
            Power = power;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.WriteLine($"Потужність: {Power}W");
        }
    }
}
