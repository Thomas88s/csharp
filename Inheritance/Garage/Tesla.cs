using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }


        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Tesla Drives by Wwwwwwooooosssshhhh!");
        }
    }
}
