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

            Foursquare foursquare = new Foursquare (40, 20, 40, Color.Black);
            listOfFigures.Add(foursquare);
            foursquare.Square(g);

            Rectangle rectangle = new Rectangle(120, 20, 80, 40, Color.Blue);
            listOfFigures.Add(rectangle);
            rectangle.Square(g);

            Triangle triangle = new Triangle(80, 80, 100, 120, 40, 160, Color.BlueViolet);
            listOfFigures.Add(triangle);
            triangle.Square(g);

            Parallelogram parallelogram = new Parallelogram(120, 140, 140, 100, 80, Color.Red);
            listOfFigures.Add(parallelogram);
            parallelogram.Square(g);

            Circle circle = new Circle(240, 80, 60, Color.Pink);
            listOfFigures.Add(circle);
            circle.Square(g);

            foreach (Figure figure in listOfFigures)
                figure.Draw(g, pen);
        }
    }
}
