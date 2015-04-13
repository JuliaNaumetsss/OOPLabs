using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    class Foursquare : Figure
    {
        private int side;
        private int square;
        private int x;
        private int y;

        public Foursquare(int side, Coord coordinate)
        {
            this.color = color;
            this.side = side;
            square = side * side;
            this.x = coordinate.x;
            this.y = coordinate.y;
        }

        public override void Square(Graphics g)
        {
            
           Point drawPoint = new Point(x+30, y+10);
            g.DrawString(square.ToString(),drawFont,brush,drawPoint, drawFormat);
        }

    }
}
