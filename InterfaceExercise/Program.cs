using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var V1 = new Car()
            {
                IsShort = true,
                IsRaceCar = true,
                HasTrunk = false,
                MaxSeats = "2",
                NumberOfDoors = "2",
                NumberOfWheels = "4",
                CompanyName = "Chevrolet",
                CompanyLogo = "A yellow plus sign"
            };
            Console.WriteLine("----------------------------------------");
            V1.PrintInfo();
            Console.WriteLine("----------------------------------------");
            var V2 = new Truck()
            {
                HasExtendedBed = false,
                HasBedWindow = true,
                HasTrunk = false,
                MaxSeats = "6",
                NumberOfDoors = "4",
                NumberOfWheels = "4",
                CompanyName = "Toyota",
                CompanyLogo = "A silver t in a circle"
            };
            Console.WriteLine("----------------------------------------");
            V2.PrintInfo();
            Console.WriteLine("----------------------------------------");
            var V3 = new SUV()
            {
                HasThreeRow = true,
                HasBigTrunk = true,
                HasTrunk = true,
                MaxSeats = "8",
                NumberOfDoors = "4",
                NumberOfWheels = "4",
                CompanyName = "Ford",
                CompanyLogo = "A blue circle that says ford"
            };
            Console.WriteLine("----------------------------------------");
            V3.PrintInfo();
            Console.WriteLine("----------------------------------------");
        }
    }
}
