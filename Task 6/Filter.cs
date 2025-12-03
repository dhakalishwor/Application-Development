using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6
{
    internal class Filter
    {
        public class Booking
        {
            public string CustomerName { get; set; }
            public string Destination { get; set; }
            public double Price { get; set; }
            public int DurationInDay { get; set; }
            public bool IsInternational { get; set; }
        }

        public static void ProcessBookings()
        {
            var bookings = new List<Booking>
            {
                new() { CustomerName = "Roman", Destination = "Paris", Price = 15000, DurationInDay = 5, IsInternational = true },
                new() { CustomerName = "Shyam Karan", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
                new() { CustomerName = "Honda", Destination = "Tokyo", Price = 20000, DurationInDay = 7, IsInternational = true },
                new() { CustomerName = "Ram", Destination = "Kathmandu", Price = 12000, DurationInDay = 2, IsInternational = false },
                new() { CustomerName = "Harry", Destination = "London", Price = 18000, DurationInDay = 6, IsInternational = true }
            };

            // Filter tours above Rs. 10,000
            var expensiveTours = bookings.Where(b => b.Price > 10000).ToList();
            Console.WriteLine("Tours above Rs. 10,000:");
            foreach (var tour in expensiveTours)
                Console.WriteLine($"{tour.CustomerName} -> {tour.Destination}, Price: {tour.Price}, Duration: {tour.DurationInDay} days");

            Console.WriteLine();

            // Filter tours with duration more than 4 days
            var longTours = bookings.Where(b => b.DurationInDay > 4).ToList();
            Console.WriteLine("Tours with duration more than 4 days:");
            foreach (var tour in longTours)
                Console.WriteLine($"{tour.CustomerName} -> {tour.Destination}, Price: {tour.Price}, Duration: {tour.DurationInDay} days");
        }
    }
}