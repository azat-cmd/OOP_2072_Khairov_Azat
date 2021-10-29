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
        protected int x, y;
        protected Graphics insrument;
        protected Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void draw(Graphics insrument)
        {
        }
    }
}
