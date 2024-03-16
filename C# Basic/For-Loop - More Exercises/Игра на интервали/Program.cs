using System;

namespace Игра_на_интервали
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfMovie = int.Parse(Console.ReadLine());
            double allPoints = 0, invalid = 0, nine = 0, nineteen = 0, twentynine = 0, thirtynine = 0, fifteen = 0;
            double point = 0;

            for (int i = 0; i < numOfMovie; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > 50 || num < 0)
                {
                    invalid++;
                    point /= 2;
                }

                else if (num <= 9)
                {
                    point += num * 0.2;
                    nine++;
                }
                else if (num <= 19)
                {
                    point += num * 0.3;
                    nineteen++;
                }
                else if (num <= 29)
                {
                    point += num * 0.4;
                    twentynine++;
                }
                else if (num <= 39)
                {
                    point += 50;
                    thirtynine++;
                }
                else if (num <= 50)
                {
                    point += 100;
                    fifteen++;
                }
            }
            Console.WriteLine($"{point:f2}");
            Console.WriteLine($"From 0 to 9: {nine / numOfMovie * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {nineteen / numOfMovie * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {twentynine / numOfMovie * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {thirtynine / numOfMovie * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {fifteen / numOfMovie * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalid / numOfMovie * 100:f2}%");
        }
    }
}
