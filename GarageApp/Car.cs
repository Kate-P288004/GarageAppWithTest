using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int doors) : base(make, model)
        {
            NumberOfDoors = doors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Make} {Model} with {NumberOfDoors} doors");
        }
    }

}
