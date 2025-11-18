using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    
        public class ParameterDemo
        {
            // 1. ref parameter: increases number by 10
            public void Increase(ref int number)
            {
                number += 10;
            }

            // 2. out parameter: it assigns a full name
            public void GetFullName(out string fullname)
            {
                fullname = "Gautam Sah";
            }

            // 3. params parameter: sum of all numbers
            public int SumAll(params int[] numbers)
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
        }

    
}