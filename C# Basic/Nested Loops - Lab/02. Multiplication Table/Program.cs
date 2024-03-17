using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sum = j * i;
                    Console.WriteLine($"{i} * {j} = {sum}");
                }
            }
        }
    }
}
