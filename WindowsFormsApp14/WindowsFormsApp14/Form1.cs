using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static Random rnd = new Random();
        string fig = "circle";

        private void button1_Click(object sender, EventArgs e)
        {
            fig = "circle";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fig = "rect";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        List<Figure> figures = new List<Figure>();
        private void Click(object sender, MouseEventArgs e)
        {
            if (!move)
            {


                int x = e.X;
                int y = e.Y;
                Graphics instrument = DrawPanel.CreateGraphics();
                if (fig == "circle")
                {
                    figures.Add(new MyCirkle(x, y, rnd.Next(20, 50)));
                }
                if (fig == "rect")
                {
                    figures.Add(new MyRectangle(x, y, 30, 30));
                }
                if (fig == "telega")
                {
                    int wid = rnd.Next(20, 50);
                    figures.Add(new Telega(x, y, wid, wid + rnd.Next(10, 20)));
                }
                if (fig == "Telega_s_uglem")
                {
                    int wid = rnd.Next(20, 50);
                    figures.Add(new Telega_s_uglem(x, y, wid, wid + rnd.Next(10, 20)));
                }
                if (fig == "Telega_s_kamnem")
                {
                    int wid = rnd.Next(20, 50);
                    figures.Add(new Telega_s_kamnem(x, y, wid, wid + rnd.Next(10, 20)));
                }
            }
            DrawPanel.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fig = "telega";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fig = "Telega_s_uglem";
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics instrument = DrawPanel.CreateGraphics();
            foreach (Figure figure in figures)
                figure.draw(instrument);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fig = "Telega_s_kamnem";
        }
        bool move = false;
        private void move_button_Click(object sender, EventArgs e)
        {

            move = true;
            
        }
        Figure figm;
        private void Down(object sender, MouseEventArgs e)
        {
            if (move)
            {
                int y = e.Y;
                int x = e.X;
                double min = 10000;
                figm = new Figure(1, 1);
                double dist;
                foreach (Figure figure in figures)
                {
                    dist = Math.Pow(figure.x - x, 2) + Math.Pow(figure.y - y, 2);
                    if (dist < min)
                    {
                        figm = figure;
                        min = dist;
                    }
                }
            }
        }

        private void Up(object sender, MouseEventArgs e)
        {
            if (move)
            {
                figm.x = e.X;
                figm.y = e.Y;
            }
            move = false;

        }
    }
}
