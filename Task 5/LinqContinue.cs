using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6
{
    internal class LinqContine
    {
        //Aggregation Operators
        public class CashierSales
        {
            public string CashierName { get; set; }
            public double Sales { get; set; }
        }

        public static void ProcessSales()
        {
            var sales = new List<CashierSales>
            {
                new() { CashierName = "Alice", Sales = 5000 },
                new() { CashierName = "Bob", Sales = 7000 },
                new() { CashierName = "Charlie", Sales = 6000 }
            };

            Console.WriteLine("---- Supermarket Sales ----");
            Console.WriteLine($"Total Cashiers: {sales.Count}");
            Console.WriteLine($"Total Sales: {sales.Sum(s => s.Sales)}");
            Console.WriteLine($"Highest: {sales.Max(s => s.Sales)}, Lowest: {sales.Min(s => s.Sales)}, Average: {sales.Average(s => s.Sales)}");
        }

        //Quantifier Operators 
        public class Applicant
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void ProcessApplicants()
        {
            var applicants = new List<Applicant>
            {
                new() { Name = "John", Age = 17 },
                new() { Name = "Roman", Age = 18 },
                new() { Name = "Sandy", Age = 19 }
            };

            Console.WriteLine(" Applicant Check");
            Console.WriteLine($"Any under 18: {applicants.Any(a => a.Age < 18)}");
            Console.WriteLine($"All above 16: {applicants.All(a => a.Age > 16)}");
        }

        //Element Operators 
        public class Music
        {
            public string Title { get; set; }
            public int DurationInSeconds { get; set; }
        }

        public static void ProcessMusic()
        {
            var songs = new List<Music>
            {
                new() { Title = "Kutu ma Kutu", DurationInSeconds = 200 },
                new() { Title = "Aaludamchana", DurationInSeconds = 260 },
                new() { Title = "Waka Waka", DurationInSeconds = 700 },
                new() { Title = "Chaiya CHaiyaa", DurationInSeconds = 1500 }
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.DurationInSeconds > 4 * 60);
            var firstAbove10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 10 * 60);

            Console.WriteLine(" Music Songs ");
            Console.WriteLine($"First song: {firstSong.Title}, Last song: {lastSong.Title}");
            Console.WriteLine($"First above 4 min: {firstAbove4Min.Title}");
            Console.WriteLine("First above 10 min: " + (firstAbove10Min != null ? firstAbove10Min.Title : "None"));
        }

        //Projection / Filtering / Sorting
        public class Book
        {
            public string Title { get; set; }
            public double Price { get; set; }
        }

        public class Student
        {
            public string Name { get; set; }
        }

        public static void ProcessOtherLINQ()
        {
            // Projection: square numbers
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squared = numbers.Select(n => n * n).ToList();
            Console.WriteLine("Squared Numbers: " + string.Join(", ", squared));

            // Filtering: premium books
            var books = new List<Book>
            {
                new() { Title = "48 laws of power", Price = 500 },
                new() { Title = "Atomic Habit", Price = 1500 },
                new() { Title = "China harayeko manxe", Price = 1200 }
            };
            var premiumBooks = books.Where(b => b.Price > 1000).Select(b => b.Title).ToList();
            Console.WriteLine("Premium Books: " + string.Join(", ", premiumBooks));

            // Sorting: student names
            var students = new List<Student>
            {
                new() { Name = "Hari" },
                new() { Name = "Ram" },
                new() { Name = "SHyam" }
            };
            var sortedStudents = students.OrderBy(s => s.Name).Select(s => s.Name).ToList();
            Console.WriteLine("Sorted Students: " + string.Join(", ", sortedStudents));
        }
    }
}