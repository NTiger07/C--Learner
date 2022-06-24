using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Guessing game");
            Console.WriteLine("-------------");
            Random randomNumber = new Random();
            int range = randomNumber.Next(1, 21);
            Console.Write("Guess a number between 1 and 20: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            int guesses = 1;

            while (guess != range)
            {
                if (guess < range)
                {
                    Console.Write("Guess is too low try again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess > range)
                {
                    Console.Write("Guess is too high try again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                guesses++;
            }
            Console.WriteLine("You are correct :) ");
            Console.WriteLine("It took you " + guesses + " tries");
        }
    }
}

