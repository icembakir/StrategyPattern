using System;
using System.Collections.Generic;
using System.Text;

namespace CarBrakeStrategyPattern
{
    public class AbsBreak : IBrakeBehavior
    {
        public void Brake()
        {
            Console.WriteLine("I've done abs brake");
        }
    }

}

