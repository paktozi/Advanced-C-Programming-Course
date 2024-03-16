using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int daysOfVacant = int.Parse(Console.ReadLine());
            string typeOfroom = Console.ReadLine();
            string rating = Console.ReadLine();
            double tot = 0;

            switch (typeOfroom)
            {
                case "apartment":
                    tot = (daysOfVacant - 1) * 25;

                    if (daysOfVacant < 10)
                    {
                        tot = tot - (tot * 0.30);
                    }
                    else if (daysOfVacant >= 10 && daysOfVacant <= 15)
                    {
                        tot = tot - (tot * 0.35);
                    }

                    else if (daysOfVacant > 15)
                    {
                        tot = tot - (tot * 0.50);
                    }
                    break;

                case "president apartment":
                    tot = (daysOfVacant - 1) * 35;

                    if (daysOfVacant < 10)
                    {
                        tot = tot - (tot * 0.10);
                    }
                    else if (daysOfVacant >= 10 && daysOfVacant <= 15)
                    {
                        tot = tot - (tot * 0.15);
                    }

                    else if (daysOfVacant > 15)
                    {
                        tot = tot - (tot * 0.20);
                    }
                    break;
                case "room for one person":
                    tot = (daysOfVacant - 1) * 18; break;
            }

            if (rating == "positive")
            {
                tot = tot + (tot * 0.25);
            }
            else if (rating == "negative")
            {
                tot = tot - (tot * 0.1);
            }
            Console.WriteLine($"{tot:f2}");
        }
    }
}
