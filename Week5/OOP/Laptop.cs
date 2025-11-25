using System;

namespace Week5.OOP
{
    internal class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery turned on.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}