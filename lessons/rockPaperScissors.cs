using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Rock, Paper and Scissors game");
            Console.WriteLine("-----------------------------");
            Random randomNumber = new Random();
            String computer = "";
            bool playAgain = true;
            String result = "";

            while (playAgain)
            {
                switch (randomNumber.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }


                Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                String human = Console.ReadLine();
                human = human.ToUpper();

                while (human != "ROCK" && human != "PAPER" && human != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    human = Console.ReadLine();
                    human = human.ToUpper();
                }

                if (human == computer)
                {
                    result = "It's a draw";
                }
                switch (human)
                {
                    case "ROCK":
                        if (computer == "PAPER")
                        {
                            result = "Computer wins";
                        }
                        else if (computer == "SCISSORS")
                        {
                            result = "You win";
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            result = "You win";
                        }
                        else if (computer == "SCISSORS")
                        {
                            result = "Computer wins";
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            result = "Computer wins";
                        }
                        else if (computer == "PAPER")
                        {
                            result = "You wins";
                        }
                        break;

                }


                Console.WriteLine("your choice: " + human);
                Console.WriteLine("Computer's choice: " + computer);
                Console.WriteLine(result);

                Console.WriteLine("Would you like to play again? (Y/N)");
                String response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

        }
    }
}

