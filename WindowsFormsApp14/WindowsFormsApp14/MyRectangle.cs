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
        int x, y, rad, count;
        Graphics instrument;
        public MyRectangle( int x, int y, int rad)
        {
            this.x = x;
            this.y = y;
            this.rad = rad;
           
        }
        public void draw(Graphics instrument)
        { 
            this.instrument = instrument;
            instrument.DrawRectangle(new Pen(Color.Black), x - rad, y - rad, rad * 2, rad * 2);
            
        }
    }
}
