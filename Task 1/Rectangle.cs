using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    internal class Rectangle
    {
        public class rectangle
        {
            private double length;
            private double breadth;

            public double Length
            {
                get => length; 
                set => length = value; 
            }

            public double breadthProperty
            {
                get => breadth; 
                set => breadth = value;
            }

            public double Getperimeter()
            {
                return 2*(length * breadth);
            }

            public String showDetails()
            {
                return $"Length: {length}, Width: {breadth}, Area: {Getperimeter()}";
            }
        }
    }
}