using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
           CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine(@$"A {MainColor} Cessna flies above Zoooooom!");
        }


        public override void Turn()
        {
            Console.WriteLine("The Cessna swoops around.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna slams on the runway.");
        }
    }
}
