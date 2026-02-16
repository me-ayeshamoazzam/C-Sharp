using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class3_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2;
        string result;
        string opt;
        bool checkResults = false;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;

            }
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn0.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (checkResults)
            {
                textBox1.Clear();
                checkResults = false;
            }
            textBox1.Text += btn00.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            int text = textBox1.Text.Length;
            if (text > 0)
            {
                textBox1.Text = textBox1.Text.Remove(text - 1);
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            opt = "-";
            textBox1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            opt = "*";
            textBox1.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            opt = "+";
            textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            opt = "/";
            textBox1.Clear();
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            opt = "%";

            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (opt)
            {
                case "+":
                    result = $"{num1 + num2}";
                    break;
                case "-":
                    result = $"{num1 - num2}";
                    break;

                case "*":
                    result = $"{num1 * num2}";
                    break;
                case "/":
                    result = $"{num1 / num2}";
                    break;
                case "%":
                    result = $"{(num1 * num2) / 100}";
                    break;
            }
            textBox1.Text = result;
            checkResults = true;
        }
    }
}

