﻿using System;
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

        bool ok = true;

        private void validationsData(int a)
        {
            if (a > 250)
            {
                MessageBox.Show("введите корректные данные(все значение меньше 250)");
                ok = false;
            }
 
        }

        private void validationsRectangle()
        {
            if ((x2.Text == "") || (y2.Text == "") || (side2.Text == "") || (side3.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                ok = false;
            }
            else
            {
                validationsData(Convert.ToInt32(x2.Text));
                validationsData(Convert.ToInt32(y2.Text));
                validationsData(Convert.ToInt32(side2.Text));
                validationsData(Convert.ToInt32(side3.Text));
                
            }
        }
        private void validationsFoursquare()
        {
            if ((x1.Text == "")||(y1.Text =="")||(side1.Text == ""))
            {
                MessageBox.Show("Заполните все поля");
                ok = false;
            }
            else
            {
                validationsData(Convert.ToInt32(x1.Text));
                validationsData(Convert.ToInt32(y1.Text));
                validationsData(Convert.ToInt32(side1.Text));
            }
 
        }
        private void validationsCircle()
        {
            if((Xc.Text=="")||(Yc.Text=="")||(radius.Text==""))
            {
                MessageBox.Show("Есть пустые поля!!!");
                ok = false;
            }
            else 
            {
                validationsData(Convert.ToInt32(Xc.Text));
                validationsData(Convert.ToInt32(Yc.Text));
                if (Convert.ToInt32(radius.Text) > 250)
                {
                    MessageBox.Show("Значение радиуса больше 250");
                    ok = false;
                }
            }
        }
        private void validationsTriangle()
        {
            if ((x5.Text == "") || (y5.Text == "") || (x6.Text == "") || (y6.Text == "") || (x7.Text == "") || (y7.Text == ""))
            {
                MessageBox.Show("Заполните все поля");
                ok = false;
            }
            else
            {
                if ((x5.Text == x6.Text) && (x5.Text == x7.Text) && (x6.Text == x7.Text))
                {
                    MessageBox.Show("Все параметры x равны");
                    ok = false;
                }
                if ((y5.Text == y6.Text) && (y5.Text == y7.Text) && (y6.Text == y7.Text))
                {
                    MessageBox.Show("Все параметры y равны");
                    ok = false;
                }
                if ((x5.Text==x6.Text)&&(y5.Text==y6.Text))
                {
                    ok = false;
                    MessageBox.Show("точки А и В совпали");
                }
                if ((x6.Text == x7.Text) && (y6.Text == y7.Text))
                {
                    ok = false;
                    MessageBox.Show("точки В и С совпали");
                }
                if ((x5.Text == x7.Text) && (y5.Text == y7.Text))
                {
                    ok = false;
                    MessageBox.Show("точки А и С совпали");
                }
                if(ok)
                {
                    validationsData(Convert.ToInt32(x5.Text));
                    validationsData(Convert.ToInt32(x6.Text));
                    validationsData(Convert.ToInt32(x7.Text));
                    validationsData(Convert.ToInt32(y5.Text));
                    validationsData(Convert.ToInt32(y6.Text));
                    validationsData(Convert.ToInt32(y7.Text));
                }
            }
        }
        private void validationsParallelogram()
        {
            if((x3.Text=="")||(y3.Text=="")||(x4.Text=="")||(y4.Text=="")||(side4.Text==""))
            {
                MessageBox.Show("есть не заполненные поля");
                ok = false;
            }
            else
            {
                if ((x3.Text == x4.Text) || (y3.Text == y4.Text))
                    MessageBox.Show("координаты х и у не должны совпадать");
                else
                {
                    validationsData(Convert.ToInt32(x3.Text));
                    validationsData(Convert.ToInt32(y3.Text));
                    validationsData(Convert.ToInt32(x4.Text));
                    validationsData(Convert.ToInt32(y4.Text));
                    validationsData(Convert.ToInt32(side4.Text));
                }
            }
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
        private void DrawFoursquare_Click(object sender, EventArgs e)
        {
            ok = true;
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            validationsFoursquare();


            if (ok)
            {
                int x = Convert.ToInt32(x1.Text);
                int y = Convert.ToInt32(y1.Text);
                int side = Convert.ToInt32(side1.Text);
                Figure.Coord coordinate = new Figure.Coord(x, y);
                Foursquare f = new Foursquare(side);

                f.Square(g);
                f.Draw(g, pen, coordinate, side);
            }
        }
        private void DrawRectangle_Click(object sender, EventArgs e)
        {
            ok = true;
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            validationsRectangle();
            if (ok)
            {
                int x = Convert.ToInt32(x2.Text);
                int y = Convert.ToInt32(y2.Text);
                int a = Convert.ToInt32(side2.Text);
                int b = Convert.ToInt32(side3.Text);

                Figure.Coord coord = new Figure.Coord(x, y);
                Rectangle f = new Rectangle(a, b);

                f.Square(g);
                f.Draw(g, pen, coord, a, b);
            }
        }
        private void DrawCircle_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            validationsCircle();
            if (ok)
            {
                int x = Convert.ToInt32(Xc.Text);
                int y = Convert.ToInt32(Yc.Text);
                Figure.Coord coordinate = new Figure.Coord(x, y);
                float circleRadius = Convert.ToInt32(radius.Text);

                Circle f = new Circle(circleRadius, coordinate);
                f.Square(g);
                f.Draw(g, pen, coordinate, circleRadius);
            }
        }

        private void DrawTriangle_Click(object sender, EventArgs e)
        {
            ok = true;
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            validationsTriangle();
            if (ok)
            {
                int xA = Convert.ToInt32(x5.Text);
                int yA = Convert.ToInt32(y5.Text);
                int xB = Convert.ToInt32(x6.Text);
                int yB = Convert.ToInt32(y6.Text);
                int xC = Convert.ToInt32(x7.Text);
                int yC = Convert.ToInt32(y7.Text);

                Figure.Coord coordA = new Figure.Coord(xA, yA);
                Figure.Coord coordB = new Figure.Coord(xB, yB);
                Figure.Coord coordC = new Figure.Coord(xC, yC);
                Triangle f = new Triangle(coordA, coordB, coordC);
                f.Square(g);
                f.Draw(g, pen, coordA, coordB, coordC);
            }
        }

        private void DrawParallelogram_Click(object sender, EventArgs e)
        {
            ok = true;
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            validationsParallelogram();
            if (ok)
            {
                int x1 = Convert.ToInt32(x3.Text);
                int x2 = Convert.ToInt32(x4.Text);
                int y1 = Convert.ToInt32(y3.Text);
                int y2 = Convert.ToInt32(y4.Text);
                int side = Convert.ToInt32(side4.Text);
                Figure.Coord coord1 = new Figure.Coord(x1, y1);
                Figure.Coord coord2 = new Figure.Coord(x2, y2);

                Parallelogram f = new Parallelogram(coord1, coord2, side);

                f.Square(g);
                f.Draw(g, pen, coord1, coord2, side);
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            x1.Visible = false;
        }

    }
}
