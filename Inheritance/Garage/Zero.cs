using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;    // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Zero drives by. 'VVVvvvvrrrrrooooomm!'");
        }
    }
}