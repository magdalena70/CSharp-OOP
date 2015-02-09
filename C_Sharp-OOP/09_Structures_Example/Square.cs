using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Structures_Example
{
    public struct Square
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public Color SurfaceColor { get; set; }
        public Color BorderColor { get; set; }
        public Edges Edges { get; set; }

        public Square(Point location, int size, Color surfaceColor, Color borderColor, Edges edges)
            : this()
        {
            this.Location = location;
            this.Size = size;
            this.SurfaceColor = surfaceColor;
            this.BorderColor = borderColor;
            this.Edges = edges;
        }

        public override string ToString()
        {
            string squareAsStr = String.Format(
                " Square[\n" +
                "\tlocation: ({0}, {1}),\n" +
                "\tsize: ({2}),\n" +
                "\tedges: ({3}),\n" +
                "\tsurface-color: #{4:X2}{5:X2}{6:X2},\n" +
                "\tborder-color: #{7:X2}{8:X2}{9:X2}\n" +
                " ];",
            this.Location.X, this.Location.Y, this.Size, this.Edges,
            this.SurfaceColor.Red, this.SurfaceColor.Green, this.SurfaceColor.Blue,
            this.BorderColor.Red, this.BorderColor.Green, this.BorderColor.Blue
                );
            return squareAsStr;
        }
    }
}
