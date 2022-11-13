using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_polyorphism
{
    internal class Triangle : Geometri
    {
        public double bas { get; set; }
        public double heigth { get; set; }
        public Triangle()
        {
            bas = 5;
            heigth = 4;
        }
        public override double Area()
        {
            return bas * heigth /2;
        }
    }
}
