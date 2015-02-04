using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            var area = this.Width * this.Height;
            return area;
        }
        public override double CalculatePerimeter()
        {
            var perimeter = (this.Width + this.Height) * 2;
            return perimeter;
        }
    }
}
