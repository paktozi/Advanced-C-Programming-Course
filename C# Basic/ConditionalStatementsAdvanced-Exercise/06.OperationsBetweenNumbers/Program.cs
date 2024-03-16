using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char sum = char.Parse(Console.ReadLine());
            double suma = 0;

            if (sum == '+')
            {
                suma = n1 + n2;

                if (suma % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {suma} - {"even"}");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {suma} - {"odd"}");
                }
            }
            else if (sum == '-')
            {
                suma = n1 - n2;

                if (suma % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {suma} - {"even"}");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {suma} - {"odd"}");
                }
            }

            else if (sum == '*')
            {
                suma = n1 * n2;

                if (suma % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {suma} - {"even"}");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {suma} - {"odd"}");
                }
            }

            else if (sum == '/')
            {

                if (n2 == 0)
                {

                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    suma = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {suma:f2}");
                }
            }
            else if (sum == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    suma = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {suma}");
                }
            }
        }
    }
}
