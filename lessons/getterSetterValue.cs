using System;


namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //getters & setters = add ssecurity to fields by encapsulations
            //                    They're accessors foind within properties

            //properties = combine aspects of both fields and methods (share name with a field)
            //get accessor = used to return the property value
            //set accessor = used to assign a new value
            //value keyword = defines a value being assigned by set (parameter)

            Car car1 = new Car(200);

            car1.Speed = 600;
            Console.WriteLine(car1.Speed);
        }
    }
    class Car
    {
        private int speed;
        public Car(int speed)
        {
            this.Speed = speed;
        }
        public int Speed
        {
            get { return speed; } //read
            set                  //write
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }

            }
        }
    }
}
