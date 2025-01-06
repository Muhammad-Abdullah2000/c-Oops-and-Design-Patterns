using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism.src.OopPrinciples.Polymorphism
{
    public class Plane : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            System.Console.WriteLine("Plane is Starting....");
        }

        public override void Stop()
        {
            System.Console.WriteLine("Plane is Stoping....");
        }
    }
}