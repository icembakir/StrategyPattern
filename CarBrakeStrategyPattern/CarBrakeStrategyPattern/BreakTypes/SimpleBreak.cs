using System;
using System.Collections.Generic;
using System.Text;

namespace CarBrakeStrategyPattern
{
    public class SimpleBrake : IBrakeBehavior
    {
        public void Brake()
        {
            Console.WriteLine("I've done simple brake");
        }
    }

}
