using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Figure
    {
        protected Color color; //feature common to all
        protected SolidBrush brush = new SolidBrush(Color.Black);
        protected StringFormat drawFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
        protected Font drawFont = new Font("Arial", 7);

        public struct Coord
        {
            public int x, y;
            public Coord(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

        }

        public virtual void Square(Graphics g)
        {

            //calculation of area figures
        }


        // draw circle
        public void Draw(Graphics g, Pen pen, int x, int y, int circleRadius) 
        {
            pen.Color = Color.Red;
            g.DrawEllipse(pen, x, y, circleRadius, circleRadius);
        }

        public void Draw(Graphics g, Pen pen, Coord coordinate, int side1, int side2)
        {
            pen.Color = Color.Blue;
            int x = coordinate.x;
            int y = coordinate.y;
            g.DrawRectangle(pen, x, y, side1, side2);
        }

        public void Draw(Graphics g, Pen pen, Coord coord1, Coord coord2, int length)
        {
            pen.Color = Color.Pink;
            g.DrawLine(pen, coord1.x, coord1.y, coord2.x, coord2.y);
            g.DrawLine(pen, coord2.x, coord2.y, coord2.x + length, coord2.y);
            g.DrawLine(pen, coord2.x + length, coord2.y, coord1.x + length, coord1.y);
            g.DrawLine(pen, coord1.x + length, coord1.y, coord1.x, coord1.y);
        }
    }
}
