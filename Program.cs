namespace ConsoleApp1;

class Circle
{
    public const double pi = 3.14;
}

class Program
{
    static void Main()
    {
        
        string userName = "Ishwor";
        int luckyNumber = 9;
        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        

        // Task 2
        
        Console.WriteLine("The value of pi is constant, so it cannot be changed.");
        double radius = 5;
        double area = Circle.pi * radius * radius;
        double perimeter = 2 * Circle.pi * radius;
        Console.WriteLine("Area of Circle is " + area + ".");
        Console.WriteLine("Perimeter of Circle is " + perimeter + ".");

        //  Task 3
        byte b = 100;
        short s = 400;
        int i = 9000;
        long l = 8000L;
        float f = 9.5f;
        double d = 3.14159;
        decimal dec = 2.5m;
        char ch = 'I';
        bool isTrue = true;

        string intToString = i.ToString();
        double stringToDouble = double.Parse("3.14");

        Console.WriteLine("byte is " + b);
        Console.WriteLine("shortis " + s);
        Console.WriteLine("int is " + i);
        Console.WriteLine("long is " + l);
        Console.WriteLine("float is " + f);
        Console.WriteLine("double is " + d);
        Console.WriteLine("decimal is" + dec);
        Console.WriteLine("char is " + ch);
        Console.WriteLine("bool is " + isTrue);
        Console.WriteLine("Converted int to string is " + intToString);
        Console.WriteLine("Converted string to double is " + stringToDouble);


        // Task 4 
        int[] favNumbers = { 9, 17, 10, 14, 2 };
        Array.Sort(favNumbers); //  its for ascending order
        Array.Reverse(favNumbers); // its for descending order

        Console.WriteLine("Reversed Sorted Array is ");
        for (int index = 0; index < favNumbers.Length; index++)
        {
            Console.WriteLine(favNumbers[index]);
        }

        int numPosition = Array.IndexOf(favNumbers, 10);
        Console.WriteLine("The position of 10 in array is " + numPosition);
        

        // Task 5 
        DateTime birthDate = new DateTime(2004, 09, 06);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = ageSpan.Days / 365;

        Console.WriteLine(" My Birthdate is " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date is " + currentDate.ToShortDateString());
        Console.WriteLine("My Age is " + ageInYears + " years");

        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine(" My Birthdate after 10 days is on " + newDate.ToShortDateString());
        

        // Task 6
        List<string> fruits = new List<string> { "Apple", "Mango", "Papaya" };
        fruits.Add("Banana");
        fruits.Remove("Apple");

        Console.WriteLine("Fruits List:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>();
        fruitDictionary.Add(1, "Apple");
        fruitDictionary.Add(2, "Mango");
        fruitDictionary.Add(3, "Orange");

        fruitDictionary.Add(4, "Pineapple");

        Console.WriteLine("Fruit Dictionary:");
        foreach (var item in fruitDictionary)
        {
            Console.WriteLine("ID: " + item.Key + " - Fruit: " + item.Value);
        }
    }
}