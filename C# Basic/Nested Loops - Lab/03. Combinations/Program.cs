using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int f = 0; f <= n; f++)
                    {
                        int sum = f + j + i;

                        if (sum == n)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
