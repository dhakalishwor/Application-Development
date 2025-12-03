using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Task_1
{

    public class Rectangle
    {

        public double length;
        public double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public double Perimeter(double length, double breadth) => 2 * (length + breadth);
    }
}

