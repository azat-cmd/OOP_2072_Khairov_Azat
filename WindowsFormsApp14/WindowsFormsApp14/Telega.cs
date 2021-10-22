using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class Telega
    {
        Graphics instrument;
        public int x, y, width, height;
        MyRectangle kuzov;
        MyCirkle koleso1;
        MyCirkle koleso2;
        public Telega(int x, int y, int width, int height)
        {
            this.x = x ;
            this.y = y ;
            kuzov = new MyRectangle(this.x, this.y - 2 * height / 10, width, 6 * height / 10);
            koleso1 = new MyCirkle(this.x - 1 * width / 4, this.y + 3 * height / 10, 2 * height / 10);
            koleso2 = new MyCirkle(this.x + 1 * width / 4, this.y + 3 * height / 10, 2 * height / 10);
            this.width = width;
            this.height = height;
        }
        public void draw(Graphics instrument)
        {
            this.instrument = instrument;
            kuzov.drawWH(instrument);
            koleso1.draw(instrument);
            koleso2.draw(instrument);
        }
    }
}
