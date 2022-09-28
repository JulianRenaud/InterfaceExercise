using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HasThreeRow { get; set; }
        public bool HasBigTrunk { get; set; }
        public bool HasTrunk { get; set; }
        public string MaxSeats { get; set; }
        public string NumberOfDoors { get; set; }
        public string NumberOfWheels { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Has three rows: {HasThreeRow}");
            Console.WriteLine($"Has big trunk: {HasBigTrunk}");
            Console.WriteLine($"Has trunk: {HasTrunk}");
            Console.WriteLine($"Max seats: {MaxSeats}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine($"Number of wheels: {NumberOfWheels}");
            Console.WriteLine($"Company name: {CompanyName}");
            Console.WriteLine($"Company logo: {CompanyLogo}");
        }
    }
}
