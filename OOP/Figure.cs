using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Figure
    {
        protected Color color; //feature common to all
        protected SolidBrush brush = new SolidBrush(Color.Black);
        protected StringFormat drawFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
        protected Font drawFont = new Font("Arial", 7);

        public virtual void Square(Graphics g)
        {

            //calculation of area figures
        }

       //public abstract void Draw(Graphics g, Pen pen);

    }
}
