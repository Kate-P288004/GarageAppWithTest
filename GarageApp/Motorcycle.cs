using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, bool sidecar) : base(make, model)
        {
            HasSidecar = sidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorcycle: {Make} {Model}, Sidecar: {HasSidecar}");
        }
    }

}
