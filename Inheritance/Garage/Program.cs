using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Lime Green";
            Tesla modelS = new Tesla();
            modelS.MainColor = "Red";
            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";
            Ram truck = new Ram();
            truck.MainColor = "grey";
            Corvette z06 = new Corvette();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            truck.Drive();
            truck.Turn();
            truck.Stop();
            z06.Drive();
            z06.Turn();
            z06.Stop();

        }
    }
}
