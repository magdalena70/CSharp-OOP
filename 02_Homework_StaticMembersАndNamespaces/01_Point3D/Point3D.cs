using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3D
    {
        //3D-coordinate {X, Y, Z} in the Euclidian 3D space
        private double x;
        private double y;
        private double z;

        //add a private static read-only field to hold the point StartingPoint {0, 0, 0}
        private static readonly Point3D startinggPoint = new Point3D(0, 0, 0);

        //add a static property to return the starting point
        public static Point3D StartingPoint
        {
            get
            {
                return startinggPoint;
            }
        }

        //create appropriate constructors
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        //create method
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //implement the ToString() to enable printing a 3D point
        public override string ToString()
        {
            return String.Format("Point's coordinates: x={0} y={1} z={2}",this.x, this.y, this.z);
        }

    }
}
