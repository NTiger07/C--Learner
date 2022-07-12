using System;

namespace MyFirstProgram
{
    class Program
    {
        //An interface defines a "contract" that all the classes inheriting from should folloow

        //       An interface declares "what a class should have"
        //       An inheriting class defines "how it should do it"

        // Benefit = security + multiple inheritance + "plug-and-play"

        public static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
        }
    }
    interface Iprey
    {
        void Flee();
    }
    interface Ipredator
    {
        void Hunt();
    }
    class Rabbit : Iprey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
    class Hawk : Ipredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk hunts!");
        }
    }
    class Fish : Iprey
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
    }
}

