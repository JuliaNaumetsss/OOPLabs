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
        private int abc; 

        public Foursquare(int x, int y, int side, Color color)
        {
            this.color = color;
            this.side = side;
            this.x = x;
            this.y = y;
            square = side * side;
        }

        public override void Square(Graphics g)
        {
            
           Point drawPoint = new Point(70, 40);
            g.DrawString(square.ToString(),drawFont,brush,drawPoint, drawFormat);
        }

       
        public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen pen)
        { 
            g.DrawRectangle(pen, x, y, side, side);
        }
    }
}
