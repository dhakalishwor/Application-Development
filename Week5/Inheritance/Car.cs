using System;

namespace ConsoleApp4.Inheritance
{
    internal class Car : Vehicle
    {
        public int Seats { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }

        internal void Display()
        {
            // reuse DisplayInfo to show same info
            DisplayInfo();
        }

        internal void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }

        internal void StopEngine()
        {
            Console.WriteLine($"{Brand} engine stopped.");
        }
    }
}