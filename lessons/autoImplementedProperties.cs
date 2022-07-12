using System;


namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Auto-Implemented properties = shortcut when no additional logic is requires in the property 
            //you do not have to define a field for a property, 
            //you only have to write {get;} and/or {set;} inside the property
            Car car1 = new Car("Porsche");
            Console.WriteLine(car1);
        }
    }
    class Car
    {
        public String Model { get; set; }
        public Car(String model)
        {
            this.Model = model;
        }
        public override String ToString()
        {
            return Model;
        }
    }

}



