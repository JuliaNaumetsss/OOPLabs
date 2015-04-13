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

        bool ok = true;
        //all fields less than 350
        private void validationsData(int a)
        {
            if (a > 350)
            {
                MessageBox.Show("введите корректные данные(все значение меньше 350)");
                ok = false;
            }
 
        }

        private void validationsRectangle()
        {
            if ((x1.Text == "") || (y1.Text == "") || (parametr1.Text == "") || (parametr2.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                ok = false;
            }
            else
            {
                validationsData(Convert.ToInt32(x1.Text));
                validationsData(Convert.ToInt32(y1.Text));
                validationsData(Convert.ToInt32(parametr1.Text));
                validationsData(Convert.ToInt32(parametr2.Text));
                
            }
        }
        private void validationsFoursquare()
        {
            if ((x1.Text == "")||(y1.Text =="")||(parametr1.Text == ""))
            {
                MessageBox.Show("Заполните все поля");
                ok = false;
            }
            else
            {
                validationsData(Convert.ToInt32(x1.Text));
                validationsData(Convert.ToInt32(y1.Text));
                validationsData(Convert.ToInt32(parametr1.Text));
            }
 
        }
        private void validationsCircle()
        {
            if((x1.Text=="")||(y1.Text=="")||(parametr1.Text==""))
            {
                MessageBox.Show("Есть пустые поля!!!");
                ok = false;
            }
            else 
            {
                validationsData(Convert.ToInt32(x1.Text));
                validationsData(Convert.ToInt32(y1.Text));
                if (Convert.ToInt32(parametr1.Text) > 250)
                {
                    MessageBox.Show("Значение радиуса больше 250");
                    ok = false;
                }
            }
        }
        private void validationsTriangle()
        {
            if ((x1.Text == "") || (y1.Text == "") || (x2.Text == "") || (y2.Text == "") || (parametr1.Text == "") || (parametr2.Text == ""))
            {
                MessageBox.Show("Заполните все поля");
                ok = false;
            }
            else
            {
                if ((x1.Text == x2.Text) && (x1.Text == parametr1.Text) && (x2.Text == parametr1.Text))
                {
                    MessageBox.Show("Все параметры x равны");
                    ok = false;
                }
                if ((y1.Text == y2.Text) && (y1.Text == parametr2.Text) && (y2.Text == parametr2.Text))
                {
                    MessageBox.Show("Все параметры y равны");
                    ok = false;
                }
                if ((x1.Text==x2.Text)&&(y1.Text==y2.Text))
                {
                    ok = false;
                    MessageBox.Show("точки А и В совпали");
                }
                if ((x2.Text == parametr1.Text) && (y2.Text == parametr2.Text))
                {
                    ok = false;
                    MessageBox.Show("точки В и С совпали");
                }
                if ((x1.Text == parametr1.Text) && (y1.Text == parametr2.Text))
                {
                    ok = false;
                    MessageBox.Show("точки А и С совпали");
                }
                if(ok)
                {
                    validationsData(Convert.ToInt32(x1.Text));
                    validationsData(Convert.ToInt32(x2.Text));
                    validationsData(Convert.ToInt32(parametr1.Text));
                    validationsData(Convert.ToInt32(y1.Text));
                    validationsData(Convert.ToInt32(y2.Text));
                    validationsData(Convert.ToInt32(parametr2.Text));
                }
            }
        }
        private void validationsParallelogram()
        {
            if((x1.Text=="")||(y1.Text=="")||(x2.Text=="")||(y2.Text=="")||(parametr1.Text==""))
            {
                MessageBox.Show("есть не заполненные поля");
                ok = false;
            }
            else
            {
                if ((x1.Text == x2.Text) || (y1.Text == y2.Text))
                    MessageBox.Show("координаты х и у не должны совпадать");
                else
                {
                    validationsData(Convert.ToInt32(x1.Text));
                    validationsData(Convert.ToInt32(y1.Text));
                    validationsData(Convert.ToInt32(x2.Text));
                    validationsData(Convert.ToInt32(y2.Text));
                    validationsData(Convert.ToInt32(parametr1.Text));
                }
            }
        }
        //limit on input (only numbers)
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


        private void x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }

        private void y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }
        private void parametr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }
        private void parametr2_KeyPress(object sender, KeyPressEventArgs e)
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
                int side = Convert.ToInt32(parametr1.Text);
                Figure.Coord coordinate = new Figure.Coord(x, y);
                Foursquare f = new Foursquare(side, coordinate);

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
                int x = Convert.ToInt32(x1.Text);
                int y = Convert.ToInt32(y1.Text);
                int a = Convert.ToInt32(parametr1.Text);
                int b = Convert.ToInt32(parametr2.Text);

                Figure.Coord coord = new Figure.Coord(x, y);
                Rectangle f = new Rectangle(a, b, coord);

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
                int x = Convert.ToInt32(x1.Text);
                int y = Convert.ToInt32(y1.Text);
                Figure.Coord coordinate = new Figure.Coord(x, y);
                float circleRadius = Convert.ToInt32(parametr1.Text);

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
                int xA = Convert.ToInt32(x1.Text);
                int yA = Convert.ToInt32(y1.Text);
                int xB = Convert.ToInt32(x2.Text);
                int yB = Convert.ToInt32(y2.Text);
                int xC = Convert.ToInt32(parametr1.Text);
                int yC = Convert.ToInt32(parametr2.Text);

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
                int xA = Convert.ToInt32(x1.Text);
                int xB = Convert.ToInt32(x2.Text);
                int yA = Convert.ToInt32(y1.Text);
                int yB = Convert.ToInt32(y2.Text);
                int side = Convert.ToInt32(parametr1.Text);
                Figure.Coord coord1 = new Figure.Coord(xA, yA);
                Figure.Coord coord2 = new Figure.Coord(xB, yB);

                Parallelogram f = new Parallelogram(coord1, coord2, side);

                f.Square(g);
                f.Draw(g, pen, coord1, coord2, side);
            }
        }

        private void RBFoursquare_Click(object sender, EventArgs e)
        {
            x1.Visible = true;
            y1.Visible = true;
            parametr1.Visible = true;
            DrawFoursquare.Visible = true;
            x2.Visible = false;
            y2.Visible = false;
            parametr2.Visible = false;
            DrawRectangle.Visible = false;
            DrawCircle.Visible = false;
            DrawTriangle.Visible = false;
            DrawParallelogram.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
        }

        private void RBRectangle_Click(object sender, EventArgs e)
        {
            x1.Visible = true;
            y1.Visible = true;
            parametr1.Visible = true;
            parametr2.Visible = true;
            DrawRectangle.Visible = true;
            x2.Visible = false;
            y2.Visible = false;
            DrawCircle.Visible = false;
            DrawTriangle.Visible = false;
            DrawParallelogram.Visible = false;
            DrawFoursquare.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
        }

        private void RBParallelogram_Click(object sender, EventArgs e)
        {
            x1.Visible = true;
            y1.Visible = true;
            x2.Visible = true;
            y2.Visible = true;
            parametr1.Visible = true;
            DrawParallelogram.Visible = true;
            parametr2.Visible = false;
            DrawCircle.Visible = false;
            DrawTriangle.Visible = false;
            DrawRectangle.Visible = false;
            DrawFoursquare.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
        }

        private void RBTriangle_Click(object sender, EventArgs e)
        {
            x1.Visible = true;
            y1.Visible = true;
            x2.Visible = true;
            y2.Visible = true;
            parametr1.Visible = true;
            parametr2.Visible = true;
            DrawTriangle.Visible = true;
            DrawCircle.Visible = false;
            DrawParallelogram.Visible = false;
            DrawRectangle.Visible = false;
            DrawFoursquare.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void RBCircle_Click(object sender, EventArgs e)
        {
            x1.Visible = true;
            y1.Visible = true;
            parametr1.Visible = true;
            DrawCircle.Visible = true;
            x2.Visible = false;
            y2.Visible = false;
            parametr2.Visible = false;
            DrawTriangle.Visible = false;
            DrawParallelogram.Visible = false;
            DrawRectangle.Visible = false;
            DrawFoursquare.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
        }

        private void CleanCoord_Click(object sender, EventArgs e)
        {
            x1.Text = "";
            x2.Text = "";
            y1.Text = "";
            y2.Text = "";
            parametr1.Text = "";
            parametr2.Text = "";
        }

        private void CleanField_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

    }
}
