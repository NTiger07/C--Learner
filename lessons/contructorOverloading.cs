using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
        }
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread)
        {
            this.bread = bread;
        }
    }
}

