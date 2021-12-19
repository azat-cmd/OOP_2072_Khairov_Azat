using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        enum Znak
        {
            pl,
            mi,
            de,
            um
        }


        private string checking(TextBox textBox, string old)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                if (!int.TryParse(textBox.Text, out int res))
                {
                    textBox.Text = old;
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else
                    old = textBox.Text;

            }
            return old;
        }
        string old1, old2, old3, old4, old5, old6 = "";
        private void Num3_TextChanged(object sender, EventArgs e)
        {
            old5 = checking(Num3, old5);
        }
        private void Del3_TextChanged(object sender, EventArgs e)
        {
            old6 = checking(Del3, old6);
        }
        private void Num2_TextChanged(object sender, EventArgs e)
        {
            old3 = checking(Num2, old3);
        }
        private void Del2_TextChanged(object sender, EventArgs e)
        {
            old4 = checking(Del2, old4);
        }
        private void Del1_TextChanged(object sender, EventArgs e)
        {
            old2 = checking(Del1, old2);
        }
        private void Num1_TextChanged(object sender, EventArgs e)
        {
            old1 = checking(Num1, old1);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Znak znak = Znak.pl;
        private void plus_Click(object sender, EventArgs e)
        {
            znak = Znak.pl;
            Znak_Label.Text = Plus.Text;
        }

        private void del_Click(object sender, EventArgs e)
        {
            znak = Znak.de;
            Znak_Label.Text = Del.Text;
        }

        private void um_Click(object sender, EventArgs e)
        {
            znak = Znak.um;
            Znak_Label.Text = Um.Text;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            znak = Znak.mi;
            Znak_Label.Text = Minus.Text;
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "" || Del1.Text == "" || Num2.Text == "" || Del2.Text == "")
            {
                return;
            }
            Rational first = new Rational(Convert.ToInt32(Num1.Text), Convert.ToInt32(Del1.Text));
            Rational second = new Rational(Convert.ToInt32(Num2.Text), Convert.ToInt32(Del2.Text));
            Rational result = new Rational(0, 0);
            if (znak == Znak.pl)
                result = (first + second).Reduction();
            else if (znak == Znak.mi)
            {
                result = first - second;
                if (result.numerator < 0)
                    result.numerator *= -1;
                result.reduction();
                result.numerator *= -1;
            }
            else if (znak == Znak.um)
                result = (first * second).Reduction();
            else if (znak == Znak.de)
                result = Rational.reduction(first / second);
            Num3.Text = result.numerator.ToString();
            Del3.Text = result.delimeter.ToString();
        }


    }
}
