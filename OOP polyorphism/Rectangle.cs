using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_polyorphism
{
    internal class Rectangle : Geometri
    {
        public double bas { get; set; }
        public double heigth { get; set; }

        public Rectangle()
        {
            bas = 4;
            heigth = 4;
        }
        public override double Area()
        {
            return bas * heigth;
        }
    }
}
