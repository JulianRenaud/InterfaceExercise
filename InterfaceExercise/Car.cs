using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool IsShort { get; set; }
        public bool IsRaceCar { get; set; }
        public bool HasTrunk { get; set; }
        public string MaxSeats { get; set; }
        public string NumberOfDoors { get; set; }
        public string NumberOfWheels { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Is short: {IsShort}");
            Console.WriteLine($"Is a race car: {IsRaceCar}");
            Console.WriteLine($"Has trunk: {HasTrunk}");
            Console.WriteLine($"Max seats: {MaxSeats}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine($"Number of wheels: {NumberOfWheels}");
            Console.WriteLine($"Company name: {CompanyName}");
            Console.WriteLine($"Company logo: {CompanyLogo}");
        }
    }
}
