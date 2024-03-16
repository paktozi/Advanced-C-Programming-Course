using System;

namespace Оценки
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfStudent = int.Parse(Console.ReadLine());
            double poor = 0, mid = 0, good = 0, well = 0;
            double allAsses = 0;

            for (int i = 0; i < numOfStudent; i++)
            {
                double asses = double.Parse(Console.ReadLine());

                if (asses <= 2.99)
                {
                    poor++;
                }
                else if (asses <= 3.99)
                {
                    mid++;
                }

                else if (asses <= 4.99)
                {
                    good++;
                }
                else
                {
                    well++;
                }

                allAsses += asses;

            }
            Console.WriteLine($"Top students: {well / numOfStudent * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good / numOfStudent * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {mid / numOfStudent * 100:f2}%");
            Console.WriteLine($"Fail: {poor / numOfStudent * 100:f2}%");
            Console.WriteLine($"Average: {allAsses / numOfStudent:f2}");
        }
    }
}
