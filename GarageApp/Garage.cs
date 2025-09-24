using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public class Garage
    {
        public List<Vehicle> Vehicles { get; } = new List<Vehicle>();

        public void AddVehicle(Vehicle v)
        {
            Vehicles.Add(v);
        }

        public void ShowAllVehicles()
        {
            Console.WriteLine("Vehicles in Garage:");
            foreach (var vehicle in Vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
    }

}
