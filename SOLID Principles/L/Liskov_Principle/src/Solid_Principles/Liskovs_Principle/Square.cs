using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liskov_Principle.src.Solid_Principles.Liskovs_Principle
{
    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double Area => SideLength * SideLength;
    }
}