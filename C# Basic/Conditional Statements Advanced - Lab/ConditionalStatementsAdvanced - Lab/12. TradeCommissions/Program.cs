using System;

namespace _12._TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double discount = 0;



            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    discount = 5;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    discount = 7;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    discount = 8;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 10000)
                {
                    discount = 12;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales <= 0)
                {
                    Console.WriteLine("error");
                }
                
           
            
            }

            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    discount = 4.5;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    discount = 7.5;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    discount = 10;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 10000)
                {
                    discount = 13;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales <= 0)
                {
                    Console.WriteLine("error");
                }


            }

            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    discount = 5.5;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    discount = 8;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    discount = 12;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales > 10000)
                {
                    discount = 14.5;
                    Console.WriteLine($"{sales * discount / 100:f2}");
                }
                else if (sales<=0)
                {
                    Console.WriteLine("error");
                }
           
            
            }

            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
