using System;

namespace Сграда
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfFloors = int.Parse(Console.ReadLine());
            int numOfRoomsPerFloor = int.Parse(Console.ReadLine());

            for (int i = numOfFloors; i >= 1; i--)
            {
                for (int j = 0; j < numOfRoomsPerFloor; j++)
                {
                    if (numOfFloors == i)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
