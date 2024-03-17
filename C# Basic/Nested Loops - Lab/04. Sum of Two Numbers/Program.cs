using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finishNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int numCount = 0;
            int countCombin = 0;

            for (int i = startNum; i <= finishNum; i++)
            {
                for (int j = startNum; j <= finishNum; j++)
                {
                    numCount++;
                    if (i + j == magicNum)
                    {
                        countCombin++;
                        Console.WriteLine($"Combination N:{numCount} ({i} + {j} = {magicNum})");
                        break;
                    }
                }
                if (countCombin == 1)
                {
                    break;
                }
            }
            if (countCombin == 0)
            {
                Console.WriteLine($"{numCount} combinations - neither equals {magicNum}");
            }
        }
    }
}

