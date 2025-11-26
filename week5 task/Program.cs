using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ========================= TASK 1: Encapsulation =========================
            Console.WriteLine("=== TASK 1: Encapsulation ===");
            BankAccount acc = new("ACC001", 500);
            acc.Deposit(200);
            acc.Withdraw(100);

            Console.WriteLine($"Account: {acc.AccountNumber}, Balance: {acc.Balance}\n");

            // ========================= TASK 2: Inheritance =========================
            Console.WriteLine("=== TASK 2: Inheritance ===");

            Car car = new("Toyota", 180, 5);
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            Motorcycle moto = new("Yamaha", 150, false);
            moto.Start();
            moto.DisplayInfo();
            moto.Stop();

            // ========================= TASK 3: Polymorphism =========================
            Console.WriteLine("\n=== TASK 3: Polymorphism ===");

            // Method Overloading
            Printer p = new();
            p.Print("Hello");
            p.Print(123);
            p.Print("Repeat", 3);

            Console.WriteLine();

            // Method overriding
            Teacher t = new("Mr. Smith");
            t.Teaching();
            t.SalaryInfo();

            NepaliTeacher nt = new("Hari");
            nt.Teaching();
            nt.SalaryInfo();

            EnglishTeacher et = new("John");
            et.Teaching();
            et.SalaryInfo();

            // ========================= TASK 4: Abstraction =========================
            Console.WriteLine("\n=== TASK 4: Abstraction ===");

            VehicleAbstract va1 = new CarAbs();
            va1.StartEngine();
            va1.StopEngine();

            VehicleAbstract va2 = new Bike();
            va2.StartEngine();
            va2.StopEngine();

            // ========================= TASK 5: Complete OOP Example =========================
            Console.WriteLine("\n=== TASK 5: Electronics Store (Full OOP Example) ===");

            ElectronicsStore store = new();
            store.AddDevice(new Laptop("Dell", 1200));
            store.AddDevice(new Smartphone("Samsung", 900));

            store.ShowAllDeviceDetails();

            Console.WriteLine("\nProgram Finished!");
        }
    }
}
