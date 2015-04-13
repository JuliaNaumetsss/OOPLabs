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


            int x = Convert.ToInt32(x1.Text);
            Check(x);
            int y = Convert.ToInt32(y1.Text);
            Check(y);
            int side = Convert.ToInt32(side1.Text);
            Check(side);
            Figure.Coord coordinate = new Figure.Coord(x, y);
            Foursquare f = new Foursquare(side);
            if (ok)
            {
                f.Square(g);
                f.Draw(g, pen, coordinate, side);
            }

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
            Figure.Coord coordinate = new Figure.Coord(x, y);
            float circleRadius = Convert.ToInt32(radius.Text);
           // Check(circleRadius);
            Circle f = new Circle(circleRadius, coordinate);
            if (ok)
            {
                f.Square(g);
                f.Draw(g, pen,coordinate, circleRadius);
            }
            //g.DrawEllipse(pen, x, y, circleRadius, circleRadius);
        }

        private void DrawTriangle_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            int xA = Convert.ToInt32(x5.Text);
            int yA = Convert.ToInt32(y5.Text);
            int xB = Convert.ToInt32(x6.Text);
            int yB = Convert.ToInt32(y6.Text);
            int xC = Convert.ToInt32(x7.Text);
            int yC = Convert.ToInt32(y7.Text);
            if ((xA == xB)||(xA == xC)||(xB == xC))
                MessageBox.Show("координаты x не должны совпадать"); 
            if ((yA == yB)||(yA == yC)||(yB == yC))
                MessageBox.Show("координаты y не должны совпадать"); 
            Triangle f = new Triangle(xA, yA, xB, yB, xC, yC);
            Figure.Coord coordA = new Figure.Coord(xA, yA);
            Figure.Coord coordB = new Figure.Coord(xB, yB);
            Figure.Coord coordC = new Figure.Coord(xC, yC);
            f.Square(g);
            f.Draw(g, pen, coordA, coordB, coordC);
        }

        private void DrawParallelogram_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            int x1 = Convert.ToInt32(x3.Text);
            Check(x1);
            int x2 = Convert.ToInt32(x4.Text);
            Check(x2);
            if (x1 == x2)
                MessageBox.Show("координаты x не должны совпадать");     
            int y1 = Convert.ToInt32(y3.Text);
            Check(y1);
            int y2 = Convert.ToInt32(y4.Text);
            Check(y2);
            if (y1 == y2)
                MessageBox.Show("координаты y не должны совпадать"); 
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
