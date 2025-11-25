using System;

namespace ConsoleApp4.Inheritance
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} started.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }
}