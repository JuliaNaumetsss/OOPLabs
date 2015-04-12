using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* public struct Coord 
        {
            public int x, y;
             public Coord(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
     
        }
        */
        bool ok = true;

      //  Coord coord1 = new Coord();
       /* private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            List<Figure> listOfFigures = new List<Figure>();
            Figure f;

           f = new Foursquare (40, Color.Black);
           listOfFigures.Add(f);
           f.Square(g);

            f = new Rectangle(120, 20, 80, 40, Color.Blue);
            listOfFigures.Add(f);
            f.Square(g);

            f = new Triangle(80, 80, 100, 120, 40, 160, Color.BlueViolet);
            listOfFigures.Add(f);
            f.Square(g);

            f = new Parallelogram(120, 140, 140, 100, 80, Color.Red);
            listOfFigures.Add(f);
            f.Square(g);

            f = new Circle(240, 80, 60, Color.Pink);
            listOfFigures.Add(f);
            f.Square(g);

            foreach (Figure figure in listOfFigures) ;
              //  figure.Draw(g, pen);
        }
        */

        private void Check(int a)
        {
            if (a > 250)
            {
                MessageBox.Show("введите корректные данные(все значение меньше 250)");
                ok = false;
            }
 
        }
        private void DrawFoursquare_Click(object sender, EventArgs e)
        {
            
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            Figure f;

            int x = Convert.ToInt32(x1.Text);
            Check(x);
            int y = Convert.ToInt32(y1.Text);
            Check(y);
            int side = Convert.ToInt32(side1.Text);
            Check(side);
            f = new Foursquare(side);
            if (ok)
                f.Square(g);

          //g.DrawRectangle(pen, x, y, side, side);
         // Draw(Graphics g, Pen pen);
    }


        private void checkSymbols(KeyPressEventArgs e)
        {
            if ((!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\d")) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }


        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void side1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void side2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void side3_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void DrawRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            

            int x = Convert.ToInt32(x2.Text);
            Check(x);
            int y = Convert.ToInt32(y2.Text);
            Check(y);
            int a = Convert.ToInt32(side2.Text);
            Check(a);
            int b = Convert.ToInt32(side3.Text);
            Check(b);
            Figure.Coord coord = new Figure.Coord(x, y);
            Rectangle f = new Rectangle(a, b);
            if (ok)
            {
                f.Square(g);
                f.Draw(g, pen, coord, a, b);
            }
        }

        private void x3_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void y3_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void x4_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void y4_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void x5_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void y5_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void x6_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void y6_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        /*private void DrawParallelogram_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.BlueViolet);
            Figure f;

            int Ax = Convert.ToInt32(x3.Text);
            Check(Ax);
            int Ay = Convert.ToInt32(y3.Text);
            Check(Ay);
            int Bx = Convert.ToInt32(x4.Text);
            Check(Bx);
            int By = Convert.ToInt32(y4.Text);
            Check(By);
            int Cx = Convert.ToInt32(x5.Text);
            Check(Cx);
            int Cy = Convert.ToInt32(y5.Text);
            Check(Cy);
            int Dx = Convert.ToInt32(x6.Text);
            Check(Dx);
            int Dy = Convert.ToInt32(y6.Text);
            Check(Dy);
            int a = Convert.ToInt32(side2.Text);
            Check(a);
            int b = Convert.ToInt32(side3.Text);
            Check(b);
            f = new Rectangle(a, b);
            if (ok)
                f.Square(g);
            g.DrawRectangle(pen, x, y, a, b);
        }
        */
        private void Xc_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void Yc_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void radius_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);

            int x = Convert.ToInt32(Xc.Text);
            Check(x);
            int y = Convert.ToInt32(Yc.Text);
            Check(y);
            int circleRadius = Convert.ToInt32(radius.Text);
            Check(circleRadius);
            Circle f = new Circle(circleRadius);
            if (ok)
            {
                f.Square(g);
                f.Draw(g, pen, x, y, circleRadius);
            }
            //g.DrawEllipse(pen, x, y, circleRadius, circleRadius);
        }

        private void DrawTriangle_Click(object sender, EventArgs e)
        {
            Figure f;
            
        }

        private void DrawParallelogram_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            int x1 = Convert.ToInt32(x3.Text);
            Check(x1);
            int x2 = Convert.ToInt32(x4.Text);
            Check(x2);
            int y1 = Convert.ToInt32(y3.Text);
            Check(y1);
            int y2 = Convert.ToInt32(y4.Text);
            Check(y2);
            int side = Convert.ToInt32(side4.Text);
            Check(side);
            Figure.Coord coord1 = new Figure.Coord(x1, y1);
            Figure.Coord coord2 = new Figure.Coord(x2, y2);
    
            Parallelogram f = new Parallelogram(coord1, coord2, side);
            if (ok)
            {
                f.Square(g);
                f.Draw(g, pen, coord1, coord2, side);
            }
        }

    }
}
