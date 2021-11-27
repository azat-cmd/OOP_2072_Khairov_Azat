﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class MyRectangle : Figure
    {
        int width, height;

        public MyRectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }

        public override void draw(Graphics instrument)
        {
            instrument.DrawRectangle(new Pen(Color.Black), x - width / 2, y - height / 2, width, height);

        }
    }
}
