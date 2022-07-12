using System;


namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //enums = special "class" that contains a set of named integer constants. 
            //Use enums when you have values that you know will not change, 
            //To get the integer value from an item, you must explicitly convert to an int
            //  name = integer
            Console.WriteLine(Companies.Google + " is the best FAANG company. It is company number # " + (int)Companies.Google);
        }
        enum Companies
        {
            FaceBook = 1,
            Apple = 2,
            Amazon = 3,
            Netflix = 4,
            Google = 5
        }
    }

}



