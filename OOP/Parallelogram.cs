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



        public Parallelogram(int x1, int y1, int x2, int y2, int length, Color color )
        {
            this.color = color;
         
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.length = length;
            square = Math.Abs(y1 - y2) * length;
      
        }

        public override void Square(Graphics g)
        {

            Point drawPoint = new Point(180, 115);
            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
        }
      /*  public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen pen)
        {
            pen.Color = color;
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x2+length, y2);
            g.DrawLine(pen, x2 + length, y2, x1+length, y1);
            g.DrawLine(pen, x1 + length, y1, x1, y1);
        }*/
    }
}
