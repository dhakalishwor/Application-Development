using System;

namespace ConsoleApp4.Inheritance
{
    internal class Motorcycle : Vehicle
    {
        public string Type { get; set; }  // example unique field

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }
}