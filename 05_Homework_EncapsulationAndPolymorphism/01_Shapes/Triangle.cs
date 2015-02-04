using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
            : base(firstSide, secondSide)
        {
            Validation.CheckForArithmeticException(firstSide, secondSide, thirdSide);
            this.ThirdSide = thirdSide;
        }

        public double ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            set
            {
                Validation.CheckForArgumentOutOfRange("triangle's third side", value);
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            var firstSide = this.Height;
            var secondSide = this.Width;
            var p = (firstSide + secondSide + this.thirdSide) / 2;
            var area = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - this.ThirdSide));
            return area;
        }

        public override double CalculatePerimeter()
        {
            var firstSide = this.Height;
            var secondSide = this.Width;
            var perimeter = firstSide + secondSide + this.thirdSide;
            return perimeter;
        }
    }
}
