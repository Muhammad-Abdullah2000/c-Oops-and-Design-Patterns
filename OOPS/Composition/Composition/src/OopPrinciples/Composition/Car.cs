using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composition.src.OopPrinciples.Composition
{
    public class Car
    {
        private Engine engine = new Engine();

        private Wheels wheels = new Wheels();

        private Chassis chassis = new Chassis();

        private Seats seats = new Seats();

        public void StartCar()
        {
            engine.engine();
            wheels.wheels();
            seats.Sit();
            System.Console.WriteLine("Car Started");
        }

    }
}