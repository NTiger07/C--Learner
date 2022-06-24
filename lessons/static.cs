using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", 2008, "Black");
            Car car2 = new Car("Ford", "Mustang", 2012, "Black");

            car1.Drive();
            car2.Drive();

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

        }
    }
    class Car
    {
        String brand;
        String model;
        int year;
        String color;
        public static int numberOfCars;
        public Car(String brand, String model, int year, String color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars++;
        }
        public void Drive()
        {
            Console.WriteLine($"A {color} {brand} {model} made in {year} is speeding along the roadway");
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has begun");
        }
    }

}

