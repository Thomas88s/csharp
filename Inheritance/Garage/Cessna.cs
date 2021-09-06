using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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
