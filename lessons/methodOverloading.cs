using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = 2;
            double y = 3;
            double z = 4;

            Console.WriteLine(Multiply(x, y));
            Console.WriteLine(Multiply(x, y, z));
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}
