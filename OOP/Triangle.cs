using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP
{
    class Triangle : Figure
    {

        private double square;
        public int x1;
        private int x2;
        private int x3;
        public int y1;
        private int y2;
        private int y3;




        public Triangle(Coord coord1, Coord coord2, Coord coord3)
        {
    
            this.x1 = coord1.x;
            this.y1 = coord1.y;
            this.x2 = coord2.x;
            this.y2 = coord2.y;
            this.x3 = coord3.x;
            this.y3 = coord3.y;
            this.color = color;
        }

        public override double Square()
        {
            double side1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double side2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double side3 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double semiperimetr = (side1 + side2 + side3) / 2;
            square = Math.Sqrt(semiperimetr * (semiperimetr - side1) * (semiperimetr - side2) * (semiperimetr - side3));
           // Point drawPoint = new Point(x1, y1);
           // g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
            return square;
        }

    }
}
