using System;

namespace ConsoleApp4
{
    internal class Car1 : Vehicle1
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}