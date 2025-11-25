using System;

namespace ConsoleApp4.Polymorphism
{
    internal class Teacher
    {
        public string Name { get; set; }

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Cannot be overridden by derived classes
        public void SalaryInfo()
        {
            Console.WriteLine("Teacher receives monthly salary.");
        }
    }
}