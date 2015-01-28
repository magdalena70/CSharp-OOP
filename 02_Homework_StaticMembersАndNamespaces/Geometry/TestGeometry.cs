using System;
using Geometry.Geometry2D;
using Geometry.Geometry3D;
using Geometry.Storage;
using Geometry.UI;

namespace Geometry
{
    class TestGeometry
    {
        static void Main()
        {
            Circle circle = new Circle();
            Ellipse ellipse = new Ellipse();
            DistanceCalculator2D calc2D = new DistanceCalculator2D();
            Figure2D figure2D = new Figure2D();
            Point2D p2D = new Point2D();
            Polygon polygon = new Polygon();
            Rectangle rect = new Rectangle();
            Square square = new Square();

            Console.WriteLine();

            DistanceCalculator3D calc3D = new DistanceCalculator3D();
            Path3D path = new Path3D();
            Point3D p3D = new Point3D();

            GeometrySVGStorage geometrySVGStorage = new GeometrySVGStorage();
            GeometryXMLStorage geometryXMLStorage = new GeometryXMLStorage();
            GeometryBinaryStorage geometryBinaryStorage = new GeometryBinaryStorage();

            Screen2D scr2D = new Screen2D();
            Screen3D scr3D = new Screen3D();

        }
    }
}
