using System;

namespace Week6
{
    internal class BuildInDelegate
    {
        //delegate for discounts
        public delegate double DiscountStrategy(double price);

        // Discount methods
        public static double SeasonalDiscount(double price) => price * 0.8;
        public static double FestivalDiscount(double price) => price * 0.9;
        public static double NoDiscount(double price) => price;

        //final price using a delegate
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
            => strategy(originalPrice);

        //  Process numbers using built-in Function
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
    }
}