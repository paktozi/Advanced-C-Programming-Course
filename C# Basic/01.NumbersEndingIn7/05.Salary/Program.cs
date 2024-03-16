using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTabs; i++)
            {
                string web = Console.ReadLine();

                if (web == "Facebook")
                {
                    salary -= 150;
                }
                else if (web == "Instagram")
                {
                    salary -= 100;
                }
                else if (web == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
