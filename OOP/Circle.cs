using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP
{
    class Circle : Figure
    {
        public float radius;
        private double square;
        public int x;
        public int y;


        public Circle(float radius, Coord coordinate)
        {

           // this.x
            this.color = color;
            this.radius = radius;
            this.x = coordinate.x;
            this.y = coordinate.y;

            square = radius * radius * Math.PI;

        }
        public override void Square(Graphics g)
        {

            Point drawPoint = new Point(315, 95);
            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
        }
       /* public override void Draw(Graphics g, Pen pen)
        {
     
            pen.Color = color;
            g.DrawEllipse(pen, x, y, radius, radius);
        }*/
    }
}
