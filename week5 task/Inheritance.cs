using System;

namespace Week5
{
    // ========================= TASK 2: Inheritance =========================
    // Parent class
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Start() => Console.WriteLine($"{Brand} is starting...");
        public void Stop() => Console.WriteLine($"{Brand} has stopped.");

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Max Speed: {Speed} km/h");
        }
    }

    // Child class 1
    class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Car, Seats: {Seats}");
        }
    }

    // Child class 2
    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, int speed, bool hasSidecar) : base(brand, speed)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Motorcycle, Sidecar: {HasSidecar}");
        }
    }
}
