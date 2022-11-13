using System;

namespace OOP_polyorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri circle = new Circle();
            Console.WriteLine("Area of the circle is: {0} cm2", circle.Area());
            Geometri triangle = new Triangle();
            Console.WriteLine("Area of the triangle is: {0} cm2", triangle.Area());
            Geometri rectangle = new Rectangle();
            Console.WriteLine("Area of the rectangle is: {0} cm2",rectangle.Area());
        }
    }
}
