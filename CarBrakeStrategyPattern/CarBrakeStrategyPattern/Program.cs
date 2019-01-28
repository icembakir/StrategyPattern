using System;

namespace CarBrakeStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car sedan = new Sedan();
            sedan.applyBrake();

            Car suv = new SUV();
            suv.applyBrake();

            suv.setBrakeBehavior(new SimpleBrake());
            suv.applyBrake();
        }
    }
}
