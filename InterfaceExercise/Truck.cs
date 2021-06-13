using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        //In each of your car, truck, and suv classes
        //Create 2 members that are specific to each class

        public int BedSize { get; set; } = 20;
        public int HorsePower { get; set; } = 1160;

        public string Logo { get; set; } = "Some Company Logo";
        public bool EVOnly { get; set; } = true;

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
