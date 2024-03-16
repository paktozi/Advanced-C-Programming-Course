using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double priceOfWashM = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            double money = 0;
            double a = 10;
            int brotherMoney = 0;
            for (int i = 1; i <= ageOfLily; i++)
            {

                if (i % 2 != 0)
                {
                    money += priceOfToy;
                }
                else
                {
                    brotherMoney++;
                    money += a;
                    a += 10;
                }
            }

            double tot = money - brotherMoney;

            if (tot >= priceOfWashM)
            {
                Console.WriteLine($"Yes! {tot - priceOfWashM:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfWashM - tot:f2}");
            }
        }
    }
}
