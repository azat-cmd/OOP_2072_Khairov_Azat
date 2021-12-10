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
        enum Figs
        {
            circle,
            rect,
            wagon,
            train,
            coal,
            sand
        }
        Figs fig = Figs.circle;
        static Random rnd = new Random();
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            fig = Figs.circle;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fig = Figs.rect;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            fig = Figs.wagon;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fig = Figs.coal;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            fig = Figs.sand;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            fig = Figs.train;
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
                if (fig == Figs.circle)
                {
                    figures.Add(new MyCirkle(x, y, rnd.Next(20, 50)));
                }
                if (fig == Figs.rect)
                {
                    figures.Add(new MyRectangle(x, y, 30, 30));
                }
                if (fig == Figs.wagon)
                {
                    figures.Add(new MyWagon(x, y, 300, 200, 33 ));
                }
                if (fig == Figs.coal)
                {
                    figures.Add(new MyWagonCoal(x, y, 300, 200));
                }
                if (fig == Figs.sand)
                {
                    figures.Add(new MyWagonSand(x, y, 300, 200));
                }
                if (fig == Figs.train)
                {
                    figures.Add(new MyTrain(x, y, 300, 200, 5));
                }
            }
            DrawPanel.Refresh();
        }

        

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics instrument = DrawPanel.CreateGraphics();
            foreach (Figure figure in figures)
                figure.draw(instrument);
        }

        
        bool move = false;
        private void move_button_Click(object sender, EventArgs e)
        {

            move = true;
            
        }
        Figure figm;
        private void Down(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Graphics instrument = DrawPanel.CreateGraphics();
            instrument.DrawRectangle(new Pen(Brushes.Blue), x - 150, y - 100, 300, 200);
            //if (move)
            //{
            //    int y = e.Y;
            //    int x = e.X;
            //    double min = 10000;
            //    figm = new Figure(1, 1);
            //    double dist;
            //    foreach (Figure figure in figures)
            //    {
            //        dist = Math.Pow(figure.x - x, 2) + Math.Pow(figure.y - y, 2);
            //        if (dist < min)
            //        {
            //            figm = figure;
            //            min = dist;
            //        }
            //    }
            //}
        }

        private void Up(object sender, MouseEventArgs e)
        {
            //if (move)
            //{
            //    figm.x = e.X;
            //    figm.y = e.Y;
            //}
            //move = false;

        }

        
    }
}
