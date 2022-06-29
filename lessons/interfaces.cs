using System;

namespace MyFirstProgram
{
    class Program
    {
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

