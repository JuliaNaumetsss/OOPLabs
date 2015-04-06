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

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            List<Figure> listOfFigures = new List<Figure>();
            Figure f;

            f = new Foursquare (40, 20, 40, Color.Black);
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

            foreach (Figure figure in listOfFigures)
                figure.Draw(g, pen);
        }
    }
}
