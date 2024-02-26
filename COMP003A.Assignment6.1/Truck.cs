﻿namespace COMP003A.Assignment6_1
{
    /// <summary>
    /// Truck extends the Vehicle Class
    /// </summary>
    internal class Truck : Vehicle
    {
        /***** fields sections *****/
        private double _sizeOfTruckBed;


        /***** constructors section *****/
        /// <summary>
        /// Constructor that takes 4 parameters: truckBrand, truckModel, truckNumberOfWheels, and sizeOfTruckBed
        /// It reuses the vase class (Vehicle)'s constructor that les 3 parameters: brand model, numberOfWheels
        /// <summary>
        /// <param name="truckBrand"></param>
        /// <param name="truckModel"></param>
        /// <param name="truckerNumberOfWheels"></param>
        /// <param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            sizeOfTruckBed = sizeOfTruckBed;
        }


        /***** properties section *****/
        public double SizeOfTruckBed
        {
            get { return _sizeOfTruckBed; }
            set { _sizeOfTruckBed = value; }
        }


        /***** methods section *****/
        /// <summary>
        /// Overrides the base Vehicle's definition for GetInfo()
        /// Calls the base Vehicle GetInfo() but adds on to it.
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}.")
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed")
        }
    }
}