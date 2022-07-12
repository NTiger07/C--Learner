using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<String> food = new List<String>();
            food.Add("pizza");
            food.Add("melon");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            //food.Insert(0, "fries");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("melon"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            String[] foodArray = food.ToArray();
        }
    }
}

