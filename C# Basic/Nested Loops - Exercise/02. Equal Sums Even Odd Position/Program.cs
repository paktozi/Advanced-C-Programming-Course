using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int mod = 0;

            for (int i = start; i <= end; i++)
            {
                int n = i;
                int odd = 0;
                int even = 0;
                int posit = 0;

                while (n != 0)
                {
                    int last = n % 10;

                    if (posit % 2 == 0)
                    {
                        even += last;
                    }
                    else
                    {
                        odd += last;
                    }

                    posit++;
                    n /= 10;
                }

                if (even == odd)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
