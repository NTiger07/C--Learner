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

            car.go();
            Console.WriteLine(car.speed);
            Console.WriteLine(car.numberOfWheels);

            bicycle.go();
            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.numberOfWheels);
        }
    }
    class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }
    class Car : Vehicle
    {
        public int numberOfWheels = 4;
    }
    class Tricycle : Vehicle
    {
        public int numberOfWheels = 3;
    }
    class Bicycle : Vehicle
    {
        public int numberOfWheels = 2;
    }
    class Boat : Vehicle
    {
        public int numberOfWheels = 0;
    }
}

