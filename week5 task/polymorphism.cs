using System;

namespace Week5
{
    // ========================= TASK 3: Polymorphism =========================
    // Method Overloading
    class Printer
    {
        public void Print(string message) => Console.WriteLine("Text: " + message);
        public void Print(int number) => Console.WriteLine("Number: " + number);

        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(message);
        }
    }

    // Base class for overriding
    class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name) => Name = name;

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Cannot be overridden
        public void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary information is confidential.");
        }
    }

    class NepaliTeacher : Teacher
    {
        public NepaliTeacher(string name) : base(name) { }

        // Method overriding
        public override void Teaching()
        {
            Console.WriteLine($"{Name} teaches in Nepali");
        }
    }

    class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name) : base(name) { }
        // Inherits base Teaching() method
    }
}
