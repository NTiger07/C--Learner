using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Method overriding = provides a new version of a method inherited from a 
            //                     parent class inherited. method must be abstract,virtual,
            //                     or already overridden Used with ToString(), polymorphism
            Dog dog = new Dog();
            Goat goat = new Goat();
            dog.MakeSound();
            goat.MakeSound();
        }
    }
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof, woof");
        }
    }
    class Goat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meeeeerrrhh");
        }
    }

}

