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

        private void Click(object sender, MouseEventArgs e)
        {
            int width = DrawPanel.Width;
            int height = DrawPanel.Height;
            int x = e.X;
            int y = e.Y;
            Graphics instrument = DrawPanel.CreateGraphics();
            if (fig == "circle")
            {
                MyCirkle circle = new MyCirkle(x, y, rnd.Next(20, 50));
                circle.draw(instrument);
            }
            if (fig == "rect")
            {
                MyRectangle rect = new MyRectangle(x, y, rnd.Next(20, 50));
                rect.draw(instrument);
            }
            if (fig == "telega")
            {
                int wid = rnd.Next(20, 50);
                Telega telega = new Telega(x, y, wid,wid + rnd.Next(10,20));
                telega.draw(instrument);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fig = "telega";
        }
    }
}
