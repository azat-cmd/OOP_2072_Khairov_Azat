using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    class Telega_s_kamnem: Telega
    {
        Graphics instrument;
        public int x, y, width, height;
        public Telega_s_kamnem(int x, int y, int width, int height) : base(x, y + 2 * height / 10, width, 8 * height / 10)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void draw(Graphics instrument)
        {
            this.instrument = instrument;
            base.draw(instrument);
            instrument.DrawRectangle(new Pen(Color.Black), x- width/4, y - 4*height / 10, width / 2, 2 * height / 10);
        }
    }
}
