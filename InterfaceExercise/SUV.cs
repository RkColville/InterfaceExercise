using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        //In each of your car, truck, and suv classes
        //Create 2 members that are specific to each class

        public int CargoSize { get; set; } = 14;
        public bool CarPlatform { get; set; } = true;

        public string Logo { get; set; } = "Some Logo";
        public bool EVOnly { get; set; } = false;

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
