using System;

namespace Week5.OOP
{
    internal class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}