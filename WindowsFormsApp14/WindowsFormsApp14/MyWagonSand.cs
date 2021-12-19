using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class MyWagonSand : MyWagon
    {
        int width, height;
        Point p1;
        Point p2;
        Point p3;
        public MyWagonSand(int x, int y, int width, int height) :
            base(x, y, width, height)
        {
            this.width = width;
            this.height = height; 

            p1 = new Point(x - width / 2, y - height / 2);
            p2 = new Point(x + width / 2, y - height / 2);
            p3 = new Point(x, y - height);
        }
        public override void draw(Graphics instrument)
        {
            base.draw(instrument);
            Point[] points = { p1, p2, p3 };
            instrument.FillPolygon(Brushes.Yellow, points);
            
        }
        public override bool IsPointInside(int x, int y)
        {
            int a = (p1.X - x) * (p2.Y - p1.Y) - (p2.X - p1.X) * (p1.Y - y);
            int b = (p2.X - x) * (p3.Y - p2.Y) - (p3.X - p2.X) * (p2.Y - y);
            int c = (p3.X - x) * (p1.Y - p3.Y) - (p1.X - p3.X) * (p3.Y - y);
            return base.IsPointInside(x, y) ||
                a > 0 && b > 0 && c > 0 ||
                a < 0 && b < 0 && c < 0 ||
                a == 0 && b == 0 && c == 0;
        }
        public override void move(int new_x, int new_y)
        {
            base.move(new_x, new_y );
            p1 = new Point(new_x - width / 2, new_y - height / 2);
            p2 = new Point(new_x + width / 2, new_y - height / 2);
            p3 = new Point(new_x, new_y - height);
        }
    }
}
