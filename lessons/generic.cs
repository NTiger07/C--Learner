using System;


namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //use generic identifier <T> to use different data types for one method
            int[] intArray = { 1, 2, 3, 4 };
            Double[] doubleArray = { 1.0, 2.0, 3.0, 4.0 };
            String[] stringArray = { "Favour", "Hatake", "Mount", "Beckham" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
        }
        public static void displayElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item);
                Console.WriteLine();
            }
        }
    }
}



