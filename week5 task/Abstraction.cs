using System;

namespace Week5
{
    // ========================= TASK 4: Abstraction =========================
    abstract class VehicleAbstract
    {
        public abstract void StartEngine();
        public abstract void StopEngine();

        public void Display() => Console.WriteLine("This is a vehicle");
    }

    class CarAbs : VehicleAbstract
    {
        public override void StartEngine() => Console.WriteLine("Car engine started with key ignition");
        public override void StopEngine() => Console.WriteLine("Car engine stopped");
    }

    class Bike : VehicleAbstract
    {
        public override void StartEngine() => Console.WriteLine("Bike engine started with kick/button");
        public override void StopEngine() => Console.WriteLine("Bike engine stopped");
    }
}
