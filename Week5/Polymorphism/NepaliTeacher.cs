using System;

namespace ConsoleApp4.Polymorphism
{
    internal class NepaliTeacher : Teacher
    {
        public override void Teaching()
        {
            Console.WriteLine("Nepali Teacher teaches in Nepali");
        }
    }
}