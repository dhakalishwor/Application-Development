using System;

namespace ConsoleApp4
{
    internal abstract class Vehicle1
    {
        public abstract void StartEngine();
        public abstract void StopEngine();

        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}