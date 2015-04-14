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
            this.color = color;
            this.radius = radius;
            this.x = coordinate.x;
            this.y = coordinate.y;

            

        }
        public override double Square()
        {
            square = radius * radius * Math.PI;
            /*Point drawPoint = new Point(x+50, y+25);

            g.DrawString(square.ToString(), drawFont, brush, drawPoint, drawFormat);*/
            return square;
        }

    }
}
