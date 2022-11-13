using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_polyorphism
{
    internal class Circle : Geometri
    {
        public double Radius { get; set; }
        public double Pi { get; set; }

        public Circle()
        {
            Radius = 4;
            Pi = 3.141d;
        }
        public override double Area()
        {
            return Radius * Radius * Pi;
        }
    }
}
