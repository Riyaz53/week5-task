using System;
using System.Collections.Generic;

namespace Week5
{
    // ========================= TASK 5: Full OOP Example =========================
    abstract class ElectronicDevice
    {
        private string brand = string.Empty;
        private double price;

        public string Brand
        {
            get => brand;
            set => brand = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Price
        {
            get => price;
            set => price = value > 0 ? value : throw new ArgumentException("Price must be positive");
        }

        protected ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public abstract void ShowInfo();
    }

    class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public void TurnOnBattery() => Console.WriteLine($"{Brand} Laptop battery is now ON");

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop  → Brand: {Brand}, Price: ${Price}");
        }
    }

    class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        public void EnableCamera() => Console.WriteLine($"{Brand} Smartphone camera enabled");

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone → Brand: {Brand}, Price: ${Price}");
        }
    }

    class ElectronicsStore
    {
        private readonly List<ElectronicDevice> devices = new();

        public void AddDevice(ElectronicDevice device) => devices.Add(device);
        public void RemoveDevice(ElectronicDevice device) => devices.Remove(device);

        public void ShowAllDeviceDetails()
        {
            if (devices.Count == 0)
            {
                Console.WriteLine("No devices in the store.");
                return;
            }

            Console.WriteLine("\n=== Devices in Store ===\n");

            foreach (var device in devices)
            {
                device.ShowInfo();

                if (device is Laptop laptop)
                    laptop.TurnOnBattery();
                else if (device is Smartphone phone)
                    phone.EnableCamera();

                Console.WriteLine();
            }
        }
    }
}
