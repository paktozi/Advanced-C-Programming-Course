using System;

namespace _06._NumberINRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number != 0 && number <= 100 && number >= -100)
            {
                Console.WriteLine("Yes");

            }
            if (number <= -101 || number >= 101 || number == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
