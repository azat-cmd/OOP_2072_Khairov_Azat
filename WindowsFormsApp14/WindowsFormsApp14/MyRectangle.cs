using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class MyRectangle : Figure
    {
        int x, y, rad, count, width,height;
        Graphics instrument;
        public MyRectangle(int x, int y, int rad) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.rad = rad;

        }
        public MyRectangle(int x, int y, int width,int height) : base(x, y)
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
        public override void draw(Graphics instrument)
        { 
            this.instrument = instrument;
            instrument.DrawRectangle(new Pen(Color.Black), x - rad, y - rad, rad * 2, rad * 2);
            
        }
    }
}
