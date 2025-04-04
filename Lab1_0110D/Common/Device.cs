namespace Lab1_0110D.Common
{
    public abstract class Device
    {
        public string Name { get; set; }
        public double Price { get; set; }

        protected Device(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void PrintInfo()
        {
            System.Console.WriteLine($"Назва: {Name}, Ціна: {Price}");
        }
    }
}
