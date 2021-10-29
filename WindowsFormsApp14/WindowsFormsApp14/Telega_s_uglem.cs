using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    class Telega_s_uglem : Telega
    {
        Graphics instrument;
        public int x, y, width, height;
        Point[] points;
        public Telega_s_uglem(int x, int y, int width, int height) : base(x, y + 2 * height / 10, width, 8 * height / 10)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            points = new Point[] { new Point(x - width / 2, y - 2 * height / 10), new Point(x, y - height / 3), new Point(x + width / 2, y - 2 * height / 10) };
        }
        public override void draw(Graphics instrument)
        {
            this.instrument = instrument;
            base.draw(instrument);
            instrument.DrawPolygon(new Pen(Color.Black), points);

        }
    }
}
