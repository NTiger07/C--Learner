using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Car[] garage = new Car[3];

            // Car car1 = new Car("Mustang", "Red");
            // Car car2 = new Car("Corvette", "Blue");
            // Car car3 = new Car("Lamborghini", "Green");

            // garage[0] = car1;
            // garage[1] = car2;
            // garage[2] = car3;


            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lamborghini") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
        }
    }
    class Car
    {
        public String model;
        public Car(String model)
        {
            this.model = model;
        }
    }

}

