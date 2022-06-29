using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Corolla", "Black", 2020, 60);
            Console.WriteLine(car);
            // Console.WriteLine(car.ToString());
        }
    }
    class Car
    {
        String Brand;
        String Model;
        String Color;
        int Year;
        int Speed;

        public Car(String Brand, String Model, String Color, int Year, int Speed)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.Year = Year;
            this.Speed = Speed;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} {Color} {Year} {Speed}";
        }

    }
}

