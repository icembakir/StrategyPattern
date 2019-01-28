using System;
using System.Collections.Generic;
using System.Text;

namespace CarBrakeStrategyPattern
{
    public abstract class Car
    {
        protected IBrakeBehavior brakeBehavior;

        public void applyBrake()
        {
            brakeBehavior.Brake();
        }
                
        public void setBrakeBehavior(IBrakeBehavior brakeType)
        {
            brakeBehavior = brakeType;
        }
    }

    public class Sedan : Car
    {
        public Sedan()
        {
            this.brakeBehavior = new SimpleBrake();
        }

    }

    public class SUV : Car
    {
        public SUV()
        {
            this.brakeBehavior = new AbsBreak();
        }

    }
}
