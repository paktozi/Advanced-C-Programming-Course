using System;

namespace a05.JourneyTWO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfBuilding = "";
            string destination = "";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    typeOfBuilding = "Camp";
                    destination = "Bulgaria";
                    budget *= 0.3;
                }
                else
                {
                    typeOfBuilding = "Hotel";
                    destination = "Bulgaria";
                    budget *= 0.7;
                }
            }

            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    typeOfBuilding = "Camp";
                    destination = "Balkans";
                    budget *= 0.4;
                }
                else
                {
                    typeOfBuilding = "Hotel";
                    destination = "Balkans";
                    budget *= 0.8;
                }
            }

            if (budget > 1000)
            {
                typeOfBuilding = "Hotel";
                destination = "Europe";
                budget *= 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfBuilding} - {budget:f2}");
        }
    }
}
