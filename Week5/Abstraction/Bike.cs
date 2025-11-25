using ConsoleApp4.Inheritance;
using System;

namespace ConsoleApp4
{
    internal class Bike : Vehicle1
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
}