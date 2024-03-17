using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double vacantPrice = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < vacantPrice)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;

                    if (sum >= vacantPrice)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }
                }
                destination = Console.ReadLine();
            }
        }
    }
}

