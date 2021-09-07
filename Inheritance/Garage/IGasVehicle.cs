using System;
using System.Collections.Generic;

namespace Garage
{
     public interface IGasVehicle
    {
        void RefuelTank();
        int CurrentTankPercentage { get; set; }
    }
}