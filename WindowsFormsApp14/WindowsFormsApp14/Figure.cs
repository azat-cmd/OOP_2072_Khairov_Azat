using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    abstract class Figure
    {
        public int x;
        public int y;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void draw(Graphics instrument)
        {
        }
        public void move(int new_x,int new_y)
        {
            x = new_x;
            y = new_y;
        }
        public virtual bool IsPointInside(int x, int y)
        {
            return true;
        }
    }
}
