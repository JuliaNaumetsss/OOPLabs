using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP
{
    class Parallelogram : Figure
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int length;
        private double square;



        public Parallelogram(Coord coord1 , Coord coord2, int length)
        {
           // this.color = color;
         
            this.x1 = coord1.x;
            this.y1 = coord1.y;
            this.x2 =coord2.x;
            this.y2 = coord2.y;
            this.length = length;
            square = Math.Abs(y1 - y2) * length;
      
        }

        public override void Square(Graphics g)
        {

            Point drawPoint = new Point(x1+10, y1+10);
            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
        }

    }
}
