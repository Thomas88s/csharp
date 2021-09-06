using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Tesla Drives by Wwwwwwooooosssshhhh!");
        }
    }
}
