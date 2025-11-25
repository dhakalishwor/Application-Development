using ConsoleApp4.Encapsulation;
using ConsoleApp4.Inheritance;
using ConsoleApp4.Polymorphism;
using System;
using Week5.OOP;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Create a BankAccount class with properties for AccountNumber and Balance. Implement methods to Deposit and Withdraw money.

            BankAccount account = new BankAccount("ACC2025", 5000);

            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Initial Balance: " + account.Balance);

            account.Deposit(1500);
            Console.WriteLine("After Deposit: " + account.Balance);

            account.Withdraw(2000);
            Console.WriteLine("After Withdraw: " + account.Balance);


            //Task 2 : Create a Vehicle base class with properties for Brand and Speed. Derive Car and Motorcycle classes from Vehicle, adding specific properties like Seats for Car and Type for Motorcycle.
            Console.WriteLine("==========Vehicle Information==========/n");
            Car car = new Car
            {
                Brand = "Toyota",
                Speed = 180,
                Seats = 5
            };

            Motorcycle bike = new Motorcycle
            {
                Brand = "Yamaha",
                Speed = 120,
                Type = "Sport"
            };

            Console.WriteLine("Car Info:");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine("\nMotorcycle Info:");
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();


            //Task 3: Create a Printer class with overloaded Print methods to print different types of data (string, int, etc.).
            Console.WriteLine("\n==========Printer Output==========/n");
            Printer printer = new Printer();

            // Calling overloaded methods
            printer.Print("Hello from Printer");
            printer.Print(123);
            printer.Print("Repeated message", 3);



            //Task 3: Create a Teacher base class with properties for Name and Subject. Derive NepaliTeacher and EnglishTeacher classes, each with their own method to display teaching style and salary information.
            Console.WriteLine("\n==========Teacher Information==========/n");
            NepaliTeacher npTeacher = new NepaliTeacher();
            npTeacher.Name = "Ram";
            Console.WriteLine("Nepali Teacher: " + npTeacher.Name);
            npTeacher.Teaching();
            npTeacher.SalaryInfo();

            Console.WriteLine();

            EnglishTeacher engTeacher = new EnglishTeacher();
            engTeacher.Name = "John";
            Console.WriteLine("English Teacher: " + engTeacher.Name);
            engTeacher.Teaching();
            engTeacher.SalaryInfo();


            //Task 4: OOP - Abstraction - Vehicle
            Car car1 = new Car();
            Bike bike1 = new Bike();

            Console.WriteLine("Car:");
            car1.Display();
            car1.StartEngine();
            car1.StopEngine();

            Console.WriteLine();

            Console.WriteLine("Bike:");
            bike1.Display();
            bike1.StartEngine();
            bike1.StopEngine();


            //Task 5: OOP - Electronic Devices
            Console.WriteLine("\n==========Electronic Devices==========/n");
            Laptop laptop = new Laptop("Dell", 85000);
            Smartphone phone = new Smartphone("Samsung", 45000);

            Console.WriteLine("Laptop Details:");
            laptop.ShowInfo();
            laptop.TurnOnBattery();

            Console.WriteLine();

            Console.WriteLine("Smartphone Details:");
            phone.ShowInfo();
            phone.EnableCamera();

            //Task 5: OOP - Electronics Store
            ElectronicsStore store = new ElectronicsStore();

            Laptop laptop1 = new Laptop("Dell", 85000);
            Smartphone phone1 = new Smartphone("Samsung", 45000);

            store.AddDevice(laptop);
            store.AddDevice(phone);

            Console.WriteLine();
            store.ShowAllDeviceDetails();

            Console.WriteLine("Removing laptop...\n");
            store.RemoveDevice(laptop);

            Console.WriteLine("After removal:");
            store.ShowAllDeviceDetails();


            //Task 5: OOP - Electronics Store with multiple stores
            ElectronicsStore store1 = new ElectronicsStore();

            // Create Laptop and Smartphone objects
            Laptop laptop2 = new Laptop("Dell", 85000);
            Smartphone phone2 = new Smartphone("Samsung", 45000);

            // Add devices to the store
            store.AddDevice(laptop);
            store.AddDevice(phone);

            // Display info of all devices including child-specific behavior
            store.ShowAllDeviceDetails();
        }
    }
}