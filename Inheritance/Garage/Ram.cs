using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle// Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Ram drives by VVVvvvvrrrrrooooomm!");
        }
    }
}