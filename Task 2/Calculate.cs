using System;

namespace Week6
{
    internal class Calculate
    {
        // Delegate for arithmetic operations
        public delegate int Operation(int num1, int num2);

        // Delegate for discount strategies
        public delegate double DiscountStrategy(double price);

        public static int Add(int num1, int num2) => num1 + num2;
        public static int Subtract(int num1, int num2) => num1 - num2;

        public static double SeasonalDiscount(double price) => price * 0.8;
        public static double FestivalDiscount(double price) => price * 0.9;
        public static double NoDiscount(double price) => price;

        static void Main(string[] args)
        {
            // Arithmetic delegate
            Operation cal;

            cal = Add;
            Console.WriteLine("Addition: " + cal(10, 5));

            cal = Subtract;
            Console.WriteLine("Subtraction: " + cal(10, 5));

            // Discount delegate
            DiscountStrategy discount;

            discount = SeasonalDiscount;
            Console.WriteLine("Seasonal Discount on 1000: " + discount(1000));

            discount = FestivalDiscount;
            Console.WriteLine("Festival Discount on 1000: " + discount(1000));

            discount = NoDiscount;
            Console.WriteLine("No Discount on 1000: " + discount(1000));
        }
    }
}