using System;
using System.Collections.Generic;

namespace Garage
{
    public interface IElectricVehicle
    {
        void ChargeBattery();
        int CurrentChargePercentage { get; set; }
    }
}