using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class TestShapes
    {
        static void Main()
        {
            var shapes = new IShape[]
        {
            new Triangle(3.1, 6.0, 5.2), 
            new Triangle(7.5, 9.0, 13.0),
            new Rectangle(12.5, 3.3),
            new Rectangle(94.0, 10.3),
            new Circle(10),
            new Circle(7.3)
        };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + ": ");
                Console.WriteLine("\tArea: {0:f2}", shape.CalculateArea());
                Console.WriteLine("\tPerimeter: {0:f2}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
