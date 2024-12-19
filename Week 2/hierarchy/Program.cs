using System;

namespace VehicleHierarchy
{
    // Base class
    public class Vehicle
    {
        // Properties common to all vehicles
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Speed { get; set; }

        // Constructor
        public Vehicle(string make, string model, int year, double speed = 0)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = speed;
        }

        // Method to accelerate
        public virtual void Accelerate(double amount)
        {
            Speed += amount;
            Console.WriteLine($"{Make} {Model} accelerates to {Speed} km/h.");
        }

        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Make} {Model} ({Year}) - Speed: {Speed} km/h");
        }
    }

    // Derived class: Car
    public class Car : Vehicle
    {
        // Additional property for Car
        public int NumberOfDoors { get; set; }

        // Constructor
        public Car(string make, string model, int year, int numberOfDoors, double speed = 0)
            : base(make, model, year, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car with {NumberOfDoors} doors.");
        }
    }

    // Derived class: Truck
    public class Truck : Vehicle
    {
        // Additional property for Truck
        public double CargoCapacity { get; set; } // in tons

        // Constructor
        public Truck(string make, string model, int year, double cargoCapacity, double speed = 0)
            : base(make, model, year, speed)
        {
            CargoCapacity = cargoCapacity;
        }

        // Overriding the Accelerate method
        public override void Accelerate(double amount)
        {
            Speed += amount * 0.8; // Trucks accelerate slower
            Console.WriteLine($"{Make} {Model} truck accelerates to {Speed} km/h.");
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Truck with {CargoCapacity} tons cargo capacity.");
        }
    }

    // Main Program
    public class Program
    {
        public static void Main()
        {
            Car myCar = new Car("Toyota", "Camry", 2022, 4);
            myCar.Accelerate(200);
            myCar.DisplayInfo();

            Truck myTruck = new Truck("Ford", "F-150", 2023, 5);
            myTruck.Accelerate(180);
            myTruck.DisplayInfo();
        }
    }
}
