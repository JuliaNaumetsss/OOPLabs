using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP
{
    public static class DrawingFigures
    {
        public static void Draw(Graphics g, Pen pen, Coord coordinate, float circleRadius)
        {
            pen.Color = Color.Red;
            //circle.ra
            g.DrawEllipse(pen, coordinate.x, coordinate.y, circleRadius, circleRadius);
            Circle f = new Circle(circleRadius, coordinate);
            Point drawPoint = new Point(f.x + 50, f.y + 25);

            g.DrawString(f.Square().ToString(), f.drawFont, f.brush, drawPoint, f.drawFormat);
        }
        //draw rectangle
        public static void Draw(Graphics g, Pen pen, Coord coordinate, int side1, int side2)
        {
            pen.Color = Color.Blue;
            int x = coordinate.x;
            int y = coordinate.y;
            g.DrawRectangle(pen, x, y, side1, side2);
            Rectangle f = new Rectangle(side1, side2, coordinate);
            Point drawPoint = new Point(x+30, y+15);
            g.DrawString(f.Square().ToString(), f.drawFont, f.brush, drawPoint, f.drawFormat);

        }
        // draw parallelogram
        public static void Draw(Graphics g, Pen pen, Coord coord1, Coord coord2, int length)
        {
            pen.Color = Color.Pink;
            g.DrawLine(pen, coord1.x, coord1.y, coord2.x, coord2.y);
            g.DrawLine(pen, coord2.x, coord2.y, coord2.x + length, coord2.y);
            g.DrawLine(pen, coord2.x + length, coord2.y, coord1.x + length, coord1.y);
            g.DrawLine(pen, coord1.x + length, coord1.y, coord1.x, coord1.y);
            Parallelogram f = new Parallelogram(coord1, coord2, length);
            Point drawPoint = new Point(f.x1+10, f.y1+10);
            g.DrawString(f.Square().ToString(), f.drawFont, f.brush, drawPoint, f.drawFormat);
        }

        // draw foursquare
        public static void Draw(Graphics g, Pen pen, Coord coordinate, int length)
        {
            pen.Color = Color.Green;
            g.DrawRectangle(pen, coordinate.x, coordinate.y, length, length);
            Foursquare f = new Foursquare(length, coordinate);
            Point drawPoint = new Point(f.x+30, f.y+10);
            g.DrawString(f.Square().ToString(),f.drawFont,f.brush,drawPoint, f.drawFormat);
        }
        // draw triangle
        public static void Draw(Graphics g, Pen pen, Coord coordinate1, Coord coordinate2, Coord coordinate3)
        {
            pen.Color = Color.Gray;
            g.DrawLine(pen, coordinate1.x, coordinate1.y, coordinate3.x, coordinate3.y);
            g.DrawLine(pen, coordinate3.x, coordinate3.y, coordinate2.x, coordinate2.y);
            g.DrawLine(pen, coordinate1.x, coordinate1.y, coordinate2.x, coordinate2.y);
            Triangle f = new Triangle(coordinate1, coordinate2, coordinate3);
            Point drawPoint = new Point(f.x1, f.y1);
            g.DrawString(f.Square().ToString(), f.drawFont, f.brush, drawPoint, f.drawFormat);
        }
    }
}
