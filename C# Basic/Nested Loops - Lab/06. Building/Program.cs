using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfFloor = int.Parse(Console.ReadLine());
            int numOfRoomPerFloor = int.Parse(Console.ReadLine());
            string empty = "";
            for (int i = 1; i <= numOfFloor; i++)
            {
                for (int j = 0; j < numOfRoomPerFloor; j++)
                {
                    if (i % 2 != 0 && i != numOfFloor)
                    {
                        empty += $"А{i}{j}";
                    }

                    if (i % 2 == 0 && i != numOfFloor)
                    {
                        empty += $"О{i}{j}";
                    }
                    if (i == numOfFloor)
                    {
                        empty += $"L{i}{j}";
                    }
                }
            }
            Console.WriteLine(empty);
        }
    }
}
