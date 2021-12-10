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
        Point p1;
        Point p2;
        Point p3;
        public MyWagonSand(int x, int y, int width, int height) :
            base(x, y + 2 * height / 10, width, 6 * height / 10, width * height / 10)
        {
            p1 = new Point(x - width / 2, y - height / 20);
            p2 = new Point(x + width / 2, y - height / 20);
            p3 = new Point(x, y - height/2);
        }
        public override void draw(Graphics instrument)
        {
            base.draw(instrument);
            Point[] points = { p1, p2, p3 };
            instrument.FillPolygon(Brushes.Yellow, points);
            instrument.DrawRectangle(new Pen(Brushes.Blue), x - width / 2, y - height / 2, width, height);
            instrument.FillEllipse(Brushes.Red, x - 5, y - 5, 10, 10);
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
    }
}
