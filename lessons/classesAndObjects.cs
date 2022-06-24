using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Human human1 = new Human("Rick", 65);
            human1.Eating();

            Human human2 = new Human("Morty", 16);
            human2.Sleeping();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Eating()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleeping()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
