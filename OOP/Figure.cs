using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public struct Coord
    {
        public int x, y;
        public Coord(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

    }
    public abstract class Figure
    {
        public Color color; //feature common to all
        public SolidBrush brush = new SolidBrush(Color.Black);
        public StringFormat drawFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
        public Font drawFont = new Font("Arial", 7);

      /*  public struct Coord
        {
            public int x, y;
            public Coord(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

        }*/

        public abstract double Square();
        

        // draw circle
       /* public void Draw(Graphics g, Pen pen, Coord coordinate, float circleRadius)
        {
            pen.Color = Color.Red;
            
            //circle.ra
            g.DrawEllipse(pen, coordinate.x, coordinate.y, circleRadius, circleRadius);
        }
        //draw rectangle
        public void Draw(Graphics g, Pen pen, Coord coordinate, int side1, int side2)
        {
            pen.Color = Color.Blue;
            int x = coordinate.x;
            int y = coordinate.y;
            g.DrawRectangle(pen, x, y, side1, side2);
        }
        // draw parallelogram
        public void Draw(Graphics g, Pen pen, Coord coord1, Coord coord2, int length)
        {
            pen.Color = Color.Pink;
            g.DrawLine(pen, coord1.x, coord1.y, coord2.x, coord2.y);
            g.DrawLine(pen, coord2.x, coord2.y, coord2.x + length, coord2.y);
            g.DrawLine(pen, coord2.x + length, coord2.y, coord1.x + length, coord1.y);
            g.DrawLine(pen, coord1.x + length, coord1.y, coord1.x, coord1.y);
        }

        // draw foursquare
        public void Draw(Graphics g, Pen pen, Coord coordinate, int length)
        {
            pen.Color = Color.Green;
            g.DrawRectangle(pen, coordinate.x, coordinate.y, length, length);
        } 
        // draw triangle
        public void Draw(Graphics g, Pen pen, Coord coordinate1, Coord coordinate2, Coord coordinate3)
        {
            pen.Color = Color.Gray;
            g.DrawLine(pen, coordinate1.x, coordinate1.y, coordinate3.x, coordinate3.y);
            g.DrawLine(pen, coordinate3.x, coordinate3.y, coordinate2.x, coordinate2.y);
            g.DrawLine(pen, coordinate1.x, coordinate1.y, coordinate2.x, coordinate2.y);
        }*/
    }
}
