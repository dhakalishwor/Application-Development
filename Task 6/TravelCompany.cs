using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6
{
    internal class TravelCompany
    {
        public class Booking
        {
            public string CustomerName { get; set; }
            public string Destination { get; set; }
            public double Price { get; set; }
            public int DurationInDay { get; set; }
            public bool IsInternational { get; set; }
        }

        public class BookingSummary
        {
            public string CustomName { get; set; }
            public string Destination { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
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
            var filtered = bookings.Where(b => b.Price > 10000);

            // Project to BookingSummary
            var projected = filtered
                .Select(b => new BookingSummary
                {
                    CustomName = b.CustomerName,
                    Destination = b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    Price = b.Price
                })
                .OrderBy(b => b.Category) // Domestic first, International next
                .ThenBy(b => b.Price)     // Sort by price within category
                .ToList();

            // Display results
            Console.WriteLine("Booking Summary:\n");
            foreach (var b in projected)
            {
                Console.WriteLine($"Name: {b.CustomName}, Destination: {b.Destination}, Category: {b.Category}, Price: {b.Price}");
            }
        }
    }
}