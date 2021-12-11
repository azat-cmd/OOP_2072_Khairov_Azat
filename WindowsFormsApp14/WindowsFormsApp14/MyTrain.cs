using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class MyTrain : Figure
    {
        
        static Random rnd;
        List<MyWagon> list;
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
        int gap;
        public MyTrain(int x, int y, int width, int height,int count) : base(x, y)
        {
            
            gap = width/10;
            rnd = new Random();
            list = new List<MyWagon>();           
            int t = rnd.Next(3);
            if (t == 0)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagon(x +(width +gap)*i, y, width , height));
                }
            if (t == 1)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagonCoal(x + (width + gap) * i, y, width, height));
                }
            if (t == 2)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagonSand(x + (width + gap) * i, y, width, height));
                }
        }
        public override void draw(Graphics instrument)
        {
            foreach (MyWagon i in list)
                i.draw(instrument);
        }
        public override bool IsPointInside(int x, int y)
        {
            bool isInside = false;
            foreach (MyWagon i in list)
                isInside = isInside || i.IsPointInside(x, y);
            return isInside;
        }
        public override void move(int new_x, int new_y)
        {
            foreach (MyWagon i in list)
                i.move(new_x, new_y);
        }
    }
}
