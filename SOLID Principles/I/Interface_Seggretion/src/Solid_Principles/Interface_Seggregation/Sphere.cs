using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Seggretion.src.Solid_Principles.Interface_Seggregation
{
    public class Sphere : IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            throw new NotImplementedException();
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}