using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Task_2
{
    public class Progran
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) => x + y;

        public static int Subtract(int x, int y) => x - y;

        public delegate double DiscountStrategy(double price);
        public static double SesonalDiscount(double price) => price * 0.8;

        public static double FestivalDiscount(double price) => price * 0.9;

        public static double NoDiscount(double price) => price;
        

        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }
         static void Main(string[] args)
        {
            Console.WriteLine("Seasonal Discount on 1000" + CalculateFinalPrice(1000, SeasonalDiscount);    
        }
    }
}
