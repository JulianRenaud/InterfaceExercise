using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool HasTrunk { get; set; }
        public string MaxSeats { get; set; }
        public string NumberOfDoors { get; set; }
        public string NumberOfWheels { get; set; }

        public void PrintInfo()
        {

        }


    }
}
