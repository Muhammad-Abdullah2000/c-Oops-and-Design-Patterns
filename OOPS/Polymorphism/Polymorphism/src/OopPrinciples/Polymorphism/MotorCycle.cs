using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism.src.OopPrinciples.Polymorphism
{
    public class MotorCycle : Vehicle
    {
        public override void Start()
        {
            System.Console.WriteLine("Bike is Starting....");
        }

        public override void Stop()
        {
            System.Console.WriteLine("Bike is Stoping....");
        }
    }
}