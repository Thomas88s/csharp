using System;
using System.Collections.Generic;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine(@$"A {MainColor} thing flies by. 'Vrooom!'");
        }

        public virtual void Turn()
        {
            Console.WriteLine(@$"The vehicle carfully turns around.");
        }

        public virtual void Stop()
        {
            Console.WriteLine(@$"The vehicle comes to a stop.");
        }
    }
}
