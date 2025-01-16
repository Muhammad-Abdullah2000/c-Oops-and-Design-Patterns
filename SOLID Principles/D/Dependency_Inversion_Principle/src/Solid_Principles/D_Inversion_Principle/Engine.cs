using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.src.Solid_Principles.D_Inversion_Principle
{
    public class Engine : IEngine
    {
        public void Start()
        {
            System.Console.WriteLine("Engine started");
        }
    }
}