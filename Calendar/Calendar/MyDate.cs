using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class MyDate
    {

        List<int> months = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int x, y, z;

        public void SetDate(int day, int month, int year)
        {
            (x, y, z) = (day, month, year);
            if (IsLeap())
                months[1] = 29;
            else
                months[1] = 28;
            if (!IsValid())
                (x, y, z) = (1, 1, 1);
           
        }
        public void NextDate()
        {
            if (x < months[y - 1])
                x++;
            else if (y < 12)
            {
                x = 1;
                y++;
            }
            else if (y == 12)
                z++;
            if (IsLeap())
                months[1] = 29;
            else
                months[1] = 28;
        }
        public bool IsLeap()
        {
            if (z % 400 == 0)
                return true;
            else if (z % 100 == 0)
                return false;
            else if (z % 4 == 0)
                return true;
            return false;
        }
        public bool IsValid()
        {
            return y < 13 && y > 0 && x <= months[y - 1] && x > 0 && z >= 0;
        }
    }
}
