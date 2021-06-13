using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    class Car : ICompany, IVehicle
    {
        //In each of your car, truck, and suv classes
        //Create 2 members that are specific to each class

        public int TrunkSize { get; set; } = 4;
        public bool IsFourDoor { get; set; } = true;

        public string Logo { get; set; } = "Logo City";
        public bool EVOnly { get; set; } = true;

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
