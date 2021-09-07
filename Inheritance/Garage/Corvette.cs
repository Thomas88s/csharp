using System;
using System.Collections.Generic;

namespace Garage
{
    public class Corvette : Vehicle// Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Corvette Drives by VVVvvvvrrrrrooooomm!");
        }
    }
}
