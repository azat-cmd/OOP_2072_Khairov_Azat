﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class MyTrain : Figure
    {
        int count;
        static Random rnd;
        List<MyWagon> list;

        public int Count
        {
            get
            {
                int sum = 0;
                foreach (MyWagon i in list)
                    sum += i.count;
                return sum;
            }
        }
        int gap;
        public MyTrain(int x, int y, int width, int height, int count) : base(x, y)
        {
            this.count = count;
            gap = (width / 10) / (count - 1);
            rnd = new Random();
            list = new List<MyWagon>();
            int t = rnd.Next(3);
            if (t == 0)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagon(x + (width / count ) * i, y, width / count , height, rnd.Next(20, 100)));
                }
            if (t == 1)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagonCoal(x + (width / count ) * i , y, width / count , height));
                }
            if (t == 2)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagonSand(x + (width / count) * i , y, width / count , height));
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
    }
}
