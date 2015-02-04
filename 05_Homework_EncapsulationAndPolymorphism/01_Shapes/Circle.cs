using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Circle : BasicShape
    {
        public Circle(double radius)
            : base(radius, 1)
        {
        }

        public override double CalculateArea()
        {
            var radius = this.Width;
            var area = Math.PI * radius * radius;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var radius = this.Width;
            var perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }
}
