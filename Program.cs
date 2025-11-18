using System;
using Week4;
using static Week4.Calculator;
using static Week4.ParaConstructor;
using static Week4.ParameterDemo;
using static Week4.Student;

class Program
{
    static void Main(string[] args)
    {
        // Creating first object
        Student s1 = new Student();
        s1.stud_name = "Gautam";
        s1.stud_age = 4;
        s1.stud_faculty = "BBA";

        // Creating second object
        Student s2 = new Student();
        s2.stud_name = "Ishwor";
        s2.stud_age = 21;
        s2.stud_faculty = "BIT";

        // Displaying object 1 values
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.stud_name);
        Console.WriteLine("Age: " + s1.stud_age);
        Console.WriteLine("Faculty: " + s1.stud_faculty);

        Console.WriteLine();

        // Displaying object 2 values
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.stud_name);
        Console.WriteLine("Age: " + s2.stud_age);
        Console.WriteLine("Faculty: " + s2.stud_faculty);

        Console.WriteLine();


        Console.WriteLine("College Name (Static Field): " + Student.collegeName);

        //Task 2: Using Calculator Class

        Console.WriteLine("Task 2 :using calculator class\n");
        Calculator calc = new Calculator();

        calc.PrintWelcome();
        Console.WriteLine("Addition: " + calc.Add(5, 10));
        Console.WriteLine("Multiplication: " + calc.Multiply(5));

        // Task 3: Using Parameter Class

        Console.WriteLine("Task 3 :using parameter class\n");
        ParameterDemo demo = new ParameterDemo();

        int value = 10;
        demo.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        demo.GetFullName(out string fullname);
        Console.WriteLine("Full Name: " + fullname);

        Console.WriteLine("Sum of numbers: " + demo.SumAll(5, 10, 15));

        //Task 4: Using Player and ParaConstructor Classes
        Console.WriteLine("PLAYER DETAILS\n");
        Player p1 = new Player();
        Console.WriteLine("Player 1 (Default Constructor):");
        p1.PrintDetails();

        Player p2 = new Player("Gautam", 5, 100);
        Console.WriteLine("Player 2 (Parameterized Constructor):");
        p2.PrintDetails();


        ParaConstructor c1 = new ParaConstructor();
        c1.PrintDetails();

        ParaConstructor c2 = new ParaConstructor("Ishwor", 5, 100);
        c2.PrintDetails();


        //Task 5
        Console.WriteLine("Task 5 :using record and enum\n");
        // Ask for day
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        // Check day type
        DayType type;

        if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);
        Console.WriteLine();

        // Book object
        Book b1 = new Book("Atomic Habits", "James Clear", 29.99);

        // Second object with updated values using 'with'
        Book b2 = b1 with { title = "Power of Habit", price = 19.50 };

        // Printing first book
        Console.WriteLine("First Book:");
        Console.WriteLine(b1);

        Console.WriteLine();

        // Deconstructing second book
        var (title, author, price) = b2;

        Console.WriteLine("Second Book:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);

        //Task 6

        Console.WriteLine("Task 6 : Debugging Practice\n");
        Console.Write("Enter marks: ");
        int marks;
        int total;

        // Using TryParse
        bool isMarksValid = int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter total: ");
        bool isTotalValid = int.TryParse(Console.ReadLine(), out total);

        if (!isMarksValid || !isTotalValid)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            return;
        }

        // BREAKPOINT 1: Set here
        double percentage = marks / total * 100;

        // BREAKPOINT 2: Set here
        Console.WriteLine("Percentage: " + percentage);
    }
}