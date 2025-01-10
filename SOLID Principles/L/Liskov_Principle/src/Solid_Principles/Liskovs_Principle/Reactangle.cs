using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liskov_Principle.src.Solid_Principles.Liskovs_Principle
{
    public class Reactangle : Shape
    {
        public virtual double Width { get; set; }

        public virtual double Height { get; set; }

        public override double Area => Width * Height;
    }
}