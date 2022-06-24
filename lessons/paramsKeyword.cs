using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            double total = AddPrices(3.99, 5.66, 8.99, 4.0);
            Console.WriteLine(total);          
        }

        static double AddPrices(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;  
            }       
            return total;     
        }
        
    }
}
