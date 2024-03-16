using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int degree = int.Parse(Console.ReadLine());
            string typeOfDay = Console.ReadLine();

            if (degree >= 10 && degree <= 18)
            {
                switch (typeOfDay)
                {
                    case "Morning": Console.WriteLine($"It's {degree} degrees, get your {"Sweatshirt"} and {"Sneakers"}."); break;
                    case "Afternoon":
                    case "Evening": Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}."); break;
                }
            }

            else if (degree > 18 && degree <= 24)
            {
                switch (typeOfDay)
                {
                    case "Morning":
                    case "Evening": Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}."); break;
                    case "Afternoon": Console.WriteLine($"It's {degree} degrees, get your {"T-Shirt"} and {"Sandals"}."); break;
                }
            }
            else if (degree >= 25)
            {
                switch (typeOfDay)
                {
                    case "Morning": Console.WriteLine($"It's {degree} degrees, get your {"T-Shirt"} and {"Sandals"}."); break;
                    case "Afternoon": Console.WriteLine($"It's {degree} degrees, get your {"Swim Suit"} and {"Barefoot"}."); break;
                    case "Evening": Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}."); break;
                }
            }
        }
    }
}




