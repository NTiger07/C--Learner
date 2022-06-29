using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Tricycle tricycle = new Tricycle();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, tricycle, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }
    class Vehicle
    {
        public int speed = 0;
        public virtual void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }
    class Car : Vehicle
    {
        public int numberOfWheels = 4;
        public override void Go()
        {
            Console.WriteLine("This car is moving");
        }
    }
    class Tricycle : Vehicle
    {
        public int numberOfWheels = 3;
        public override void Go()
        {
            Console.WriteLine("This tricycle is moving");
        }
    }
    class Bicycle : Vehicle
    {
        public int numberOfWheels = 2;
        public override void Go()
        {
            Console.WriteLine("This bicycle is moving");
        }
    }
    class Boat : Vehicle
    {
        public int numberOfWheels = 0;
        public override void Go()
        {
            Console.WriteLine("This boat is moving");
        }
    }
}

