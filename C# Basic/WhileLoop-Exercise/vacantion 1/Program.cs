using System;

namespace vacantion_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeedForvacant = double.Parse(Console.ReadLine());
            double cash = double.Parse(Console.ReadLine());
            int days = 0;
            int spend = 0;

            while (moneyNeedForvacant > cash && spend < 5)
            {
                string saveOrSpend = Console.ReadLine();
                double moneySaveOrSpend = double.Parse(Console.ReadLine());
                days++;

                if (saveOrSpend == "spend")
                {
                    spend++;
                    if (cash - moneySaveOrSpend < 0)
                    {
                        cash = 0;
                    }
                    else
                    {
                        cash -= moneySaveOrSpend;
                    }
                }
                else if (saveOrSpend == "save")

                {
                    cash += moneySaveOrSpend;
                    spend = 0;
                }
            }

            if (spend == 5)

            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (cash >= moneyNeedForvacant)

            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
