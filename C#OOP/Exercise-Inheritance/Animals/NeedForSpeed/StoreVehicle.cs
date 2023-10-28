using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class StoreVehicle<T>
    {
        public List<T> VehicleList = new();


        public void AddToList(T item)
        {
            VehicleList.Add(item);
        }
        public void PrintVehicle()
        {
            foreach (var item in VehicleList)
            {
               Console.WriteLine(item);
            }
        }

    }
}
