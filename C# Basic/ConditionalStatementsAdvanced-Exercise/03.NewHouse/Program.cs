using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //Роза Далия Лале Нарцис Гладиола
            //5     3.80    2.80    3         2.50

            //double Roses = 5, Dahlias=3.8, Tulips=2.8, Narcissus=3, Gladiolus =2.5;

            double price = 0;

            string typeOfFlowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            switch (typeOfFlowers)
            {
                case "Roses": price = 5; break;
                case "Dahlias": price = 3.8; break;
                case "Tulips": price = 2.8; break;
                case "Narcissus": price = 3; break;
                case "Gladiolus": price = 2.5; break;

            }

            double tot = price * numOfFlowers;

            if (typeOfFlowers == "Roses" && numOfFlowers > 80)
            {
                tot = tot - (tot * 0.1);
            }
            else if (typeOfFlowers == "Dahlias" && numOfFlowers > 90)
            {
                tot = tot - (tot * 0.15);
            }
            else if (typeOfFlowers == "Tulips" && numOfFlowers > 80)
            {
                tot = tot - (tot * 0.15);
            }

            else if (typeOfFlowers == "Narcissus" && numOfFlowers < 120)
            {
                tot = tot + tot * 0.15;
            }
            else if (typeOfFlowers == "Gladiolus" && numOfFlowers < 80)
            {

                tot = tot + tot * 0.20;
            }

            if (budget >= tot)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeOfFlowers} and {budget - tot:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {tot - budget:f2} leva more.");
            }
        }
    }
}
