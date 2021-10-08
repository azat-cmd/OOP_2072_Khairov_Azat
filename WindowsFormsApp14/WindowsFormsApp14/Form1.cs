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
        bool circle = false;
        bool rect = false;

        private void button1_Click(object sender, EventArgs e)
        {
            circle = true;
            rect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circle = false;
            rect = true;
            
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
            if (circle)
            {
                MyCirkle circle = new MyCirkle(x, y, rnd.Next(20, 50));
                Graphics instrument = DrawPanel.CreateGraphics();
                circle.draw(instrument);
            }
            if (rect)
            {
                MyRectangle rect = new MyRectangle(x, y, rnd.Next(20, 50));
                Graphics instrument = DrawPanel.CreateGraphics();
                rect.draw(instrument);
            }
        }
    }
}
