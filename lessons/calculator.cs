using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            String oper = Console.ReadLine();

            while (oper != "+" && oper != "-" && oper != "*" && oper != "/")
            {
                Console.WriteLine("Choose a valid operation (+, -, *, /: )/");
                oper = Console.ReadLine();
            }

            Console.WriteLine("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine("Result is: " + result);
        }
    }
}
