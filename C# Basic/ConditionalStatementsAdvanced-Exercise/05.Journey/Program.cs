using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfBuilding = "";
            string destination = "";

            if (season == "summer")
            {
                typeOfBuilding = "Camp";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    budget = budget * 0.3;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    budget = budget * 0.4;
                }
            }

            else if (season == "winter")
            {
                typeOfBuilding = "Hotel";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    budget = budget * 0.7;
                }

                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    budget = budget * 0.8;
                }
            }

            if (budget > 1000)
            {
                typeOfBuilding = "Hotel";
                destination = "Europe";
                budget = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfBuilding} - {budget:f2}");
        }
    }
}
