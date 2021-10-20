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

        private string checking(TextBox textBox, string old)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                if (int.TryParse(textBox.Text, out int res) != true)
                {
                    textBox.Text = old;
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else
                    old = textBox.Text;

            }
            return old;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool[] ar = { false, false, false, false };
        private void zero_ar(bool[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                ar[i] = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = button1.Text;
            zero_ar(ar);
            ar[0] = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            old5 = checking(textBox5, old5);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = button3.Text;
            zero_ar(ar);
            ar[3] = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = button2.Text;
            zero_ar(ar);
            ar[1] = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = button4.Text;
            zero_ar(ar);
            ar[2] = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                return;
            }
            Rational first = new Rational(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Rational second = new Rational(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            Rational result = new Rational(0, 0);
            if (ar[0])
                result = (first + second).Reduction();
            else if (ar[1])
            {
                result = first - second;
                if (result.numerator < 0)
                    result.numerator *= -1;
                result.reduction();
                result.numerator *= -1;
            }
            else if (ar[2])
                result = (first * second).Reduction();
            else if (ar[3])
                result = Rational.reduction(first / second);
            textBox5.Text = result.numerator.ToString();
            textBox6.Text = result.delimeter.ToString();
        }

        string old1, old2, old3, old4, old5, old6 = "";

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            old6 = checking(textBox6, old6);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            old3 = checking(textBox3, old3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            old4 = checking(textBox4, old4);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            old2 = checking(textBox2, old2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            old1 = checking(textBox1, old1);


        }
    }
}
