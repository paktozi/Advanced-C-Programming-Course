using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("OK");

            Cake cake = new("cake");

            Console.WriteLine($"{cake.Name} {cake.Price} {cake.Grams} {cake.Calories}");
        }
    }
}