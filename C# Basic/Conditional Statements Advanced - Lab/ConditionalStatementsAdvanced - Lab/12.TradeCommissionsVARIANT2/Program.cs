using System;

namespace _12.TradeCommissionsVARIANT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comm = 0;
            switch(town)
            {
                case "Sofia":
                    if(sales>=0&&sales<=500)
                    {
                        comm = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comm = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comm = sales * 0.12;
                    }
                    break;

                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comm = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comm = sales * 0.1;
                    }
                    else if (sales > 10000)
                    {
                        comm = sales * 0.13;
                    }
                    break;

                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comm = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comm = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comm = sales * 0.145;
                    }
                    break;


            }

            if (sales < 0|| (town != "Plovdiv" && town != "Varna" && town != "Sofia"))
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comm:f2}");
                
            }




        }
    }
}
