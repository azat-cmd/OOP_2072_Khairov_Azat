using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class MyCirkle
    {
        public Control parent;
        Graphics instrument;
        public int x, y, rad;
        public MyCirkle( int x, int y, int rad)
        {
            this.x = x - rad / 2;
            this.y = y - rad / 2;
            this.rad = rad;
            
        }
        public void draw(Graphics instrument)
        {
            this.instrument = instrument;
            this.parent = parent;
            instrument.DrawEllipse(new Pen(Color.Black), x, y, rad * 2, rad * 2);
        }
        
    }
}
