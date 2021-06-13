using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done -- Create 2 Interfaces called IVehicle & ICompany

            //Done -- Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Done --Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Done -- Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Done --Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * *Done --Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            Car car1 = new Car();
            Truck truck1 = new Truck();
            SUV suv1 = new SUV();

            car1.Color = "Red";
            car1.Year = 1998;
            car1.Make = "Pontiac";
            car1.Model = "Prowler";
            

            truck1.Color = "Blue";
            truck1.Year = 2021;
            truck1.Make = "Toyota";
            truck1.Model = "Tundra";

            suv1.Color = "Pearl White";
            suv1.Year = 2022;
            suv1.Make = "Lexus";
            suv1.Model = "G460";


            //Done -- Creatively display and organize their values

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Color: {vehicle.Color} Make: {vehicle.Make} Model: {vehicle.Model} ");
                Console.WriteLine();
                


            }
            Console.WriteLine($"Is the car a 4 door? {car1.IsFourDoor}. The trunk size is {car1.TrunkSize} square feet!");
            Console.WriteLine();
            Console.WriteLine($"The bed size of the truck is {truck1.BedSize} square feet and the horsepower is {truck1.HorsePower}!");
            Console.WriteLine();
            Console.WriteLine($"The SUV has cargo space in the amount of {suv1.CargoSize} square feet.");
            Console.WriteLine($"The SUV on a car platform? {suv1.CarPlatform}.");

        }
    }
}
