using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //enum Month
        //{
        //    Jan = 1,
        //    Feb,
        //    Mar,
        //    Apr,
        //    May,
        //    Jun,
        //    Jul,
        //    Aug,
        //    Sep,
        //    Oct,
        //    Nov,
        //    Dec
        //}
        MyDate calend = new MyDate();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetDateButton_Click(object sender, EventArgs e)
        {
            calend.SetDate((int)(x.Value), (int)(y.Value),(int)(z.Value));
            x.Value = calend.x;
            y.Value = calend.y;
            z.Value = calend.z;
            NextDateButton.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void NextDateButton_Click(object sender, EventArgs e)
        {
            calend.NextDate();
            x.Value = calend.x;
            y.Value = calend.y;
            z.Value = calend.z;
        }
    }
}
