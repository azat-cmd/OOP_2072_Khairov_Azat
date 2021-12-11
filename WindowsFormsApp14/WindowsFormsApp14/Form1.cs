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
            None,
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
        private bool IsInt(string str)
        {
            return Int32.TryParse(str, out int a);
        }
        List<Figure> figures = new List<Figure>();
        private void Click(object sender, MouseEventArgs e)
        {
            if (!move)
            {


                int x = e.X;
                int y = e.Y;
                Graphics instrument = DrawPanel.CreateGraphics();
                if (fig == Figs.circle && IsInt(rad.Text))
                {
                    figures.Add(new MyCirkle(x, y, Convert.ToInt32(rad.Text)));
                }
                if (fig == Figs.rect && IsInt(width.Text) && IsInt(height.Text))
                {
                    figures.Add(new MyRectangle(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
                }
                if (fig == Figs.wagon && IsInt(width.Text) && IsInt(height.Text))
                {
                    figures.Add(new MyWagon(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
                }
                if (fig == Figs.coal && IsInt(width.Text) && IsInt(height.Text))
                {
                    figures.Add(new MyWagonCoal(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
                }
                if (fig == Figs.sand && IsInt(width.Text) && IsInt(height.Text))
                {
                    figures.Add(new MyWagonSand(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
                }
                if (fig == Figs.train && IsInt(width.Text) && IsInt(height.Text) && IsInt(count.Text))
                {
                    figures.Add(new MyTrain(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text), Convert.ToInt32(count.Text)));
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
        bool moveOK;
        private void Down(object sender, MouseEventArgs e)
        {

            if (move)
            {
                moveOK = false;
                int x = e.X;
                int y = e.Y;
                foreach (Figure fig in figures)
                {
                    if (fig.IsPointInside(x, y))
                    {
                        figm = fig;
                        moveOK = true;
                    }
                        ;
                    continue;
                }
            }


        }

        private void Up(object sender, MouseEventArgs e)
        {
            if (moveOK)
            {
                int x = e.X;
                int y = e.Y;
                figm.move(x, y);
                move = false;
                moveOK = false;
                DrawPanel.Refresh();
                fig = Figs.None;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            figures = new List<Figure>();
            DrawPanel.Refresh();
        }
    }
}
