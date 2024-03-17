using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfFloors = int.Parse(Console.ReadLine());
            int numOfRoomsPerFloor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 1; i++)
            {

                for (int j = 0; j < numOfRoomsPerFloor; j++)
                {

                    if (numOfFloors == i)
                    {
                        Console.Write($"*");
                        
                    }
                    
                    else if (i % 2 == 0)
                    {
                        Console.Write($"*");

                    }

                    else
                    {
                        Console.Write($"*");

                    }

                }

                Console.WriteLine();

            }




        }
    }
}
