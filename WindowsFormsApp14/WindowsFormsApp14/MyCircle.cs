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
        public int rad;
       
        public MyCirkle( int x, int y,int rad) : base(x, y)
        {
           
            this.rad = rad;

        }
        public override void draw(Graphics instrument)
        {
            instrument.DrawEllipse(new Pen(Color.Black), x-rad, y-rad, rad * 2, rad * 2);
        }
        public override bool IsPointInside(int x, int y)
        {
            double distantion = Math.Pow(this.x - x, 2) + Math.Pow(this.y - y,2);
            return distantion <= Math.Pow(rad, 2);                
        }
    }
}
