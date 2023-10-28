using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StoreVehicle<object> vehicle = new();
           
            Car car = new(10, 20);
            Motorcycle motorcycle = new(8, 4);

            vehicle.AddToList(car);
           vehicle.AddToList(motorcycle);

            vehicle.PrintVehicle();
        }
    }
}
