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
            base(x ,y,width,height)
        {            
            coal = new MyRectangle(x, y - 7*height/10 , 8*width/10, 4 * height / 10);
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
        public override void move(int new_x, int new_y)
        {
            base.move(new_x, new_y );
            coal.move(new_x, new_y - 7 * height / 10);
        }
    }
}
