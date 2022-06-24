using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            happyBirthday("John", 53);
        }
        static void happyBirthday(String name, int age)
        {
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday to you, " + name);
            Console.WriteLine("Happy " + age + "th birthday to you");
            Console.WriteLine("");
        }
    }
}
