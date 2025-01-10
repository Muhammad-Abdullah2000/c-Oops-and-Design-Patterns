using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Closed_Principle.src.SolidPrinciples.Open_Closed_Principle
{
    public class Reactangle : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}