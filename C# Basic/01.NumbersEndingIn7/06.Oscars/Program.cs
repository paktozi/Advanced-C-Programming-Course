using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int numOfJudge = int.Parse(Console.ReadLine());
            double totp = 0;

            for (int i = 0; i < numOfJudge; i++)
            {
                string nameOfJudge = Console.ReadLine();
                double pointsOFJudge = double.Parse(Console.ReadLine());
                totp += nameOfJudge.Length * pointsOFJudge / 2;
            }

            double totfin = totp + pointsOfAcademy;
            if (totfin > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totfin:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - totfin:f1} more!");
            }
        }
    }
}
