using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Rectangle : Figure
    {
        private int x;
        private int y;
        private int side1;
        private int side2;
        private int square;

        public Rectangle(int width, int length, Coord coordinate)
        {
      
            this.side1 = width;
            this.side2 = length;
            square = side1 * side2;
            this.x = coordinate.x;
            this.y = coordinate.y;

        }
        public override void Square(Graphics g)
        {

            Point drawPoint = new Point(x+30, y+15);
            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
        }

    }
}
