using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class MyWagon : Figure
    {
       
        public int width;
        public int height;
        MyRectangle telega;
        MyCirkle koleso1;
        MyCirkle koleso2;
        public MyWagon(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;

            telega = new MyRectangle(x, y - 2 * height / 10, width, 3 * height / 5);
            koleso1 = new MyCirkle(x - width / 4, y +  height / 3, height / 6);
            koleso2 = new MyCirkle(x + width / 4, y + height/3, height / 6);
        }
        public override void draw(Graphics instrument)
        {
            telega.draw(instrument);
            koleso1.draw(instrument);
            koleso2.draw(instrument);
        }
        public override bool IsPointInside(int x, int y)
        {
            return telega.IsPointInside(x, y) || koleso1.IsPointInside(x, y) || koleso2.IsPointInside(x, y);
        }
        public override void move(int new_x, int new_y)
        {
            telega.move(new_x, new_y - 2 * height / 10);
            koleso1.move(new_x - width / 4, new_y + height / 3);
            koleso2.move(new_x + width / 4, new_y + height / 3);
        }
    }
}
