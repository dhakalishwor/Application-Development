using System;

namespace Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Create a class named 'Rectangle' with private fields for length and breadth.
            var rect = new Rectangle.rectangle();

            rect.Length = 10;
            rect.breadthProperty = 5;

            Console.WriteLine(rect.showDetails());
            Console.ReadLine();


            //Task 2: 
              Calculate.Operation cal;

            cal = Calculate.Add;
            Console.WriteLine("Addition: " + cal(10, 5));

            cal = Calculate.Subtract;
            Console.WriteLine("Subtraction: " + cal(10, 5));

            // Discount delegate
            Calculate.DiscountStrategy discount;

            discount = Calculate.SeasonalDiscount;
            Console.WriteLine("Seasonal Discount on 1000: " + discount(1000));

            discount = Calculate.FestivalDiscount;
            Console.WriteLine("Festival Discount on 1000: " + discount(1000));

            discount = Calculate.NoDiscount;
            Console.WriteLine("No Discount on 1000: " + discount(1000));

            Console.ReadLine();


            //Task 2.1: Using Custom Delegates for Discount Strategies

            double price = 1000;

            Calculator.ShowAllDiscounts(price);
            Calculator.ShowLambdaDiscount(price);

            Console.ReadLine();

            //Task 3: Using Predicate and Func Delegates

            int[] nums = { 3, 6, 12, 20, 9, 1, 14 };

            Console.WriteLine("Even Numbers:");
            BuildInDelegate.ProcessNumbers(nums, n => n % 2 == 0);

            Console.WriteLine("Numbers > 10:");
            BuildInDelegate.ProcessNumbers(nums, n => n > 10);

            Console.WriteLine("Seasonal Discount: " +
                BuildInDelegate.CalculateFinalPrice(1000, BuildInDelegate.SeasonalDiscount));

            Console.WriteLine("Festival Discount: " +
                BuildInDelegate.CalculateFinalPrice(1000, BuildInDelegate.FestivalDiscount));

            Console.WriteLine("Lambda 30% Discount: " +
                BuildInDelegate.CalculateFinalPrice(1000, p => p * 0.7));

            Console.ReadLine();

            //Task 4: LINQ Operations

            Console.WriteLine("Squared Numbers: " +
               string.Join(", ", Linq.SquareNumbers(new List<int> { 1, 2, 3, 4, 5 })));

            Console.WriteLine("Premium Books: " +
                string.Join(", ", Linq.GetPremiumBookTitles(new List<Linq.Book>
                {
                    new() { Tittle = "Book A", Price = 500 },
                    new() { Tittle = "Book B", Price = 1500 },
                    new() { Tittle = "Book C", Price = 1200 }
                })));

            Console.WriteLine("Sorted Students: " +
                string.Join(", ", Linq.GetSortedStudentNames(new List<Linq.Student>
                {
                    new() { Name = "John" },
                    new() { Name = "Alice" },
                    new() { Name = "Bob" }
                })));



            //Task 5
            LinqContine.ProcessSales();
            LinqContine.ProcessApplicants();
            LinqContine.ProcessMusic();
            LinqContine.ProcessOtherLINQ();

            //Task 6
            Filter.ProcessBookings();

            //Task 6.1:
            TravelCompany.ProcessBookings();

        }
    }
}