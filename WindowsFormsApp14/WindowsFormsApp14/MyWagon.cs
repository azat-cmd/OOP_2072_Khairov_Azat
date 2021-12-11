using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class MyWagon : MyRectangle
    {
       
        public int width;
        public int height;
        MyCirkle koleso1;
        MyCirkle koleso2;
        public MyWagon(int x, int y, int width, int height) : base(x, y - 2 * height / 10, width, 3 * height / 5)
        {
            this.width = width;
            this.height = height;
            
            koleso1 = new MyCirkle(x - width / 4, y +  height / 3, height / 6);
            koleso2 = new MyCirkle(x + width / 4, y + height/3, height / 6);
        }
        public override void draw(Graphics instrument)
        {
            base.draw(instrument);
            koleso1.draw(instrument);
            koleso2.draw(instrument);
        }
        public override bool IsPointInside(int x, int y)
        {
            return base.IsPointInside(x, y) || koleso1.IsPointInside(x, y) || koleso2.IsPointInside(x, y);
        }
        public override void move(int new_x, int new_y)
        {
            base.move(new_x, new_y);
            koleso1.move(new_x, new_y);
            koleso2.move(new_x, new_y);
        }
    }
}
