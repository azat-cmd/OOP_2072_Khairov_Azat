using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class MyCirkle : Figure
    {
        Graphics instrument;
        public int x, y, rad;
        public MyCirkle( int x, int y,int rad) : base(x, y)
        {
            this.x = x - rad;
            this.y = y - rad;
            this.rad = rad;

        }
        public override void draw(Graphics instrument)
        {
            this.instrument = instrument;
            instrument.DrawEllipse(new Pen(Color.Black), x, y, rad * 2, rad * 2);
        }
        
    }
}
