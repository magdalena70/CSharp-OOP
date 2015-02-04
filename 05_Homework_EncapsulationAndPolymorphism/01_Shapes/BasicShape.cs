using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Validation.CheckForArgumentOutOfRange("first parameter - width", value);
                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Validation.CheckForArgumentOutOfRange("second parameter - height", value);
                this.height = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
