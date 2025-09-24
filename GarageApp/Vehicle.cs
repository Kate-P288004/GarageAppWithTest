using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Make} {Model}");
        }
    }

}
