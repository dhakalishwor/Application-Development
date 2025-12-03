using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6
{
    internal class Linq
    {
        //Square numbers
        public static List<int> SquareNumbers(List<int> numbers)
            => numbers.Select(n => n * n).ToList();

        //Filter premium books (price > 1000)
        public class Book
        {
            public string Tittle { get; set; }
            public double Price { get; set; }
        }

        public static List<string> GetPremiumBookTitles(List<Book> books)
            => books.Where(b => b.Price > 1000)
                    .Select(b => b.Tittle)
                    .ToList();

        //Sort student names alphabetically
        public class Student
        {
            public string Name { get; set; }
        }

        public static List<string> GetSortedStudentNames(List<Student> students)
            => students.OrderBy(s => s.Name)
                       .Select(s => s.Name)
                       .ToList();
    }
}