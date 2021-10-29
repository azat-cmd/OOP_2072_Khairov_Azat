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
            int x = e.X;
            int y = e.Y;
            Graphics instrument = DrawPanel.CreateGraphics();
            if (fig == "circle")
            {
                figures.Add(new MyCirkle(x, y, rnd.Next(20, 50)));
            }
            if (fig == "rect")
            {
                figures.Add(new MyRectangle(x, y, rnd.Next(20, 50)));
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
    }
}
