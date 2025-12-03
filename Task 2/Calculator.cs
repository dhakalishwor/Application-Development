using System;

namespace ConsoleApp5
{
    internal class Calculator
    {

        public delegate double DiscountStrategy(double price);

        public static double SeasonalDiscount(double price) => price * 0.8;
        public static double FestivalDiscount(double price) => price * 0.9;
        public static double NoDiscount(double price) => price;

        // To calculate final price
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
            => strategy(originalPrice);

        //prints results 
        public static void ShowAllDiscounts(double price)
        {
            Console.WriteLine("Seasonal Discount: " + CalculateFinalPrice(price, SeasonalDiscount));
            Console.WriteLine("Festival Discount: " + CalculateFinalPrice(price, FestivalDiscount));
            Console.WriteLine("No Discount: " + CalculateFinalPrice(price, NoDiscount));
        }

        //prints lambda-based discount
        public static void ShowLambdaDiscount(double price)
        {
            DiscountStrategy lambdaDiscount = p => p * 0.7;   // 30% off
            Console.WriteLine("Lambda 30% Discount: " + CalculateFinalPrice(price, lambdaDiscount));
        }
    }
}