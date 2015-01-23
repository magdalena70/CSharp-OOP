using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Point
    {
        //fields
        private int x_Coord;
        private int y_Coord;

        //constructor
        public Point(int x_Coord, int y_Coord)
        {
            this.x_Coord = x_Coord;
            this.y_Coord = y_Coord;
        }

        //properties
        public int X_Coord
        {
            get
            {
                return this.x_Coord;
            }
            set
            {
                this.x_Coord = value;
            }
        }

        public int Y_Coord
        {
            get
            {
                return this.y_Coord;
            }
            set
            {
                this.y_Coord = value;
            }
        }

        //create method
        public double CalcDistance(Point p)
        {
            return Math.Sqrt((p.x_Coord - this.x_Coord) * (p.x_Coord - this.x_Coord) +
                             (p.y_Coord - this.y_Coord) * (p.y_Coord - this.y_Coord));
        }
    }



