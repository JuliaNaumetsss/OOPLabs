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
        private int x1;
        private int x2;
        private int x3;
        private int y1;
        private int y2;
        private int y3;




        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Color color)
        {
    
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.color = color;
            double side1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double side2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double side3 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double semiperimetr = (side1 + side2 + side3) / 2;
            square = Math.Sqrt(semiperimetr * (semiperimetr - side1) * (semiperimetr - side2) * (semiperimetr - side3));
        }

        public override void Square(Graphics g)
        {

            Point drawPoint = new Point(95, 110);
            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);
        }
       /* public override void Draw(Graphics g, Pen pen)
        {
            pen.Color = color;
            g.DrawLine(pen, x1, y1, x3, y3);
            g.DrawLine(pen, x3, y3, x2, y2);
            g.DrawLine(pen, x1, y1, x2, y2);
        }*/
    }
}
