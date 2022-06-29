using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car[] garage = new Car[3];

            Car car1 = new Car("Mustang", "Red");
            Car car2 = Copy(car1);

            // changeColor(car1, "blue");
            Console.WriteLine(car2.color);
        }
        // public static void changeColor(Car car, String color)
        // {
        //     car.color = color;
        // }
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;
        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }

}

