using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class MyRectangle
    {
        int x, y, rad, width,height;
        Graphics instrument;
        public MyRectangle( int x, int y, int rad)
        {
            this.x = x;
            this.y = y;
            this.rad = rad;
           
        }
        public MyRectangle(int x, int y, int width,int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }
        public void drawWH(Graphics instrument)
        {
            this.instrument = instrument;
            instrument.DrawRectangle(new Pen(Color.Black), x - width/2, y - height/2, width, height);

        }
        public void draw(Graphics instrument)
        { 
            this.instrument = instrument;
            instrument.DrawRectangle(new Pen(Color.Black), x - rad, y - rad, rad * 2, rad * 2);
            
        }
    }
}
