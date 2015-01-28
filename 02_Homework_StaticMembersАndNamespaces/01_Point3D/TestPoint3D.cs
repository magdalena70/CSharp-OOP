using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class TestPoint3D
    {
        public static void Main()
        {
            Point3D point = new Point3D(0.5, 1.2, 4.0);
            Point3D start = Point3D.StartingPoint;

            Console.WriteLine(point);
            Console.WriteLine(start);
        }
       

    }
}
