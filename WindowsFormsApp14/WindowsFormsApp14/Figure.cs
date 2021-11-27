using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    class Figure
    {
        public int x, y;
        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void draw(Graphics insrument)
        {
        }
        public void move(int new_x,int new_y)
        {
            x = new_x;
            y = new_y;
        }
    }
}
