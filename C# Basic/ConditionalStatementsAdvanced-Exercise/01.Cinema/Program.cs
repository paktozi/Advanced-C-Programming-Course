using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int numOfColunm = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            double price = 0;

            switch (typeOfProjection)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.5; break;
                case "Discount": price = 5; break;
            }

            double tot = price * row * numOfColunm;

            Console.WriteLine($"{tot:f2} leva");
        }
    }
}
