using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Task_2
{
    public class Calculate
    {x`
        static void main(string[] args)
        {
            Calculate caculate;
            caculate = Add;
            Console.WriteLine("Addition:" + caculate(10, 2));

            caculate = Subtract;
            Console.WriteLine("Subtract:" + caculate(10, 2));

            DiscountStrategy discount;
            discount = SesonalDiscount;
            Console.WriteLine("Seasonal Discount on 1000" + discount(1000));
            discount = FestivalDiscount;
            Console.WriteLine("Festival Discount on 1000" + discount(1000));
            discount = NoDiscount;
            Console.WriteLine("Theres no discount on 1000");
        }
    }
}
