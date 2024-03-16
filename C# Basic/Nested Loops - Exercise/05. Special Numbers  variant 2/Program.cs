using System;

namespace _05._Special_Numbers__variant_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool spec = true;

                int num = i;
                while (num != 0)
                {
                    int lastNum = num % 10;

                    if (lastNum == 0 || n % lastNum != 0)
                    {
                        spec = false;
                        break;
                    }
                    num /= 10;
                }

                if (spec)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
