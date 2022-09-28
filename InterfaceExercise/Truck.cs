using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasExtendedBed { get; set; }
        public bool HasBedWindow { get; set; }
        public bool HasTrunk { get; set; }
        public string MaxSeats { get; set; }
        public string NumberOfDoors { get; set; }
        public string NumberOfWheels { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Has extended bed: {HasExtendedBed}");
            Console.WriteLine($"Has bed window: {HasBedWindow}");
            Console.WriteLine($"Has trunk: {HasTrunk}");
            Console.WriteLine($"Max seats: {MaxSeats}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine($"Number of wheels: {NumberOfWheels}");
            Console.WriteLine($"Company name: {CompanyName}");
            Console.WriteLine($"Company logo: {CompanyLogo}");
        }
    }
}
