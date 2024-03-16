using System;

namespace Логистика
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfCargo = int.Parse(Console.ReadLine());

            double cargoBus = 0, cargoTruck = 0, cargoTrain = 0;
            int tones = 0;
            for (int i = 0; i < numOfCargo; i++)
            {
                int weightCargo = int.Parse(Console.ReadLine());


                if (weightCargo <= 3)
                {
                    cargoBus += weightCargo;
                }
                else if (weightCargo <= 11)
                {
                    cargoTruck += weightCargo;
                }
                else
                {
                    cargoTrain += weightCargo;
                }
            }

            double allTones = cargoBus + cargoTruck + cargoTrain;

            //Първи ред – средната цена на тон превозен товар(закръглена до втория знак след дес. запетая);

            double mintones = (cargoBus * 200 + cargoTruck * 175 + cargoTrain * 120) / 25;
            Console.WriteLine($"{mintones:f2}");
            Console.WriteLine($"{cargoBus / allTones * 100:f2}%");
            Console.WriteLine($"{cargoTruck / allTones * 100:f2}%");
            Console.WriteLine($"{cargoTrain / allTones * 100:f2}%");
        }
    }
}
