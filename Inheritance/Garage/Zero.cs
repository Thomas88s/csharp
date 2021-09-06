using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Zero drives by. 'VVVvvvvrrrrrooooomm!'");
        }
    }
}