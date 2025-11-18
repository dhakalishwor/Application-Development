using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    
        public class Calculator
        {
            // Method 1: Prints welcome message
            public void PrintWelcome()
            {
                Console.WriteLine("Welcome to the Calculator");
            }

            // Method 2: Returns addition
            public int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            // Method 3: Optional parameter (num2 = 1)
            public int Multiply(int num1, int num2 = 1)
            {
                return num1 * num2;
            }
        }

    
}