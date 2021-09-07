using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle// Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;// method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Ram drives by VVVvvvvrrrrrooooomm!");
        }
    }
}
