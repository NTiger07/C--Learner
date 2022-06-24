using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is a demo, so enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter a NUMBER you muppet: ");
                int number = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }
        }
    }
}

