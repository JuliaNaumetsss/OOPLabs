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
        private int radius;
        private double square;
        private int x;
        private int y;


        public Circle(int x, int y, int radius, Color color)
        {

 
            this.color = color;
            this.radius = radius;
            this.x = x;
            this.y = y;
            square = radius * radius * Math.PI;

        }
        public override void Square(Graphics g)
        {

            Point drawPoint = new Point(315, 95);
            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
        }
        public override void Draw(Graphics g, Pen pen)
        {
     
            pen.Color = color;
            g.DrawEllipse(pen, x, y, radius, radius);
        }
    }
}
