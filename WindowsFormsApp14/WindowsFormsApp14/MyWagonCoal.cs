using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class MyWagonCoal:MyWagon
    {
        MyRectangle coal;
        public MyWagonCoal(int x, int y,int width, int height):            
            base(x ,y-2*height/10,width,8*height/10,width*height/5)
        {
            coal = new MyRectangle(x, y - height / 2 + height / 10, 8*width/10, 2 * height / 10);
        }
        public override void draw(Graphics instrument)
        {
            base.draw(instrument);
            coal.draw(instrument);
        }
        public override bool IsPointInside(int x, int y)
        {
            return base.IsPointInside(x, y)|| coal.IsPointInside(x,y);
        }
    }
}
