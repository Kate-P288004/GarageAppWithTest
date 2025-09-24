using GarageApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        Garage myGarage = new Garage();

        
        myGarage.AddVehicle(new Car("Tesla", "Model S", 4));
        myGarage.AddVehicle(new Motorcycle("Ducati", "Monster", true));
        myGarage.AddVehicle(new Car("Mazda", "CX-5", 5));
        myGarage.AddVehicle(new Motorcycle("Harley-Davidson", "Iron 883", false));

      
        myGarage.ShowAllVehicles();

        Console.ReadLine();
    }

}

