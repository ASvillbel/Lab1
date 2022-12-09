using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Калькулятор : Form
    {
        Calc C;
        
        bool znak = true;

        public Калькулятор()
        {
            InitializeComponent();
            C = new Calc();
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                if (znak == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
                else if (znak == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    znak = true;
                }
            }
            else
            {
                if (znak == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
                else if (znak == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    znak = true;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!button3.Enabled)
                {
                    textBox1.Text = C.Sum(Convert.ToDouble(textBox1.Text)).ToString();
                    button3.Enabled = true;
                    label1.Text = "";
                }

                if (!button9.Enabled)
                {
                    textBox1.Text = C.Min(Convert.ToDouble(textBox1.Text)).ToString();
                    button9.Enabled = true;
                    label1.Text = "";
                }

                if (!button10.Enabled)
                {
                    textBox1.Text = C.Mult(Convert.ToDouble(textBox1.Text)).ToString();
                    button10.Enabled = true;
                    label1.Text = "";
                }

                double b = double.Parse(textBox1.Text);
                if (!button14.Enabled && b != 0)
                {
                    textBox1.Text = C.Division(Convert.ToDouble(textBox1.Text)).ToString();
                    button14.Enabled = true;
                    label1.Text = "";
                }
                else if (b == 0)
                {
                    textBox1.Text = "infinity";
                    button14.Enabled = true;
                    label1.Text = "";
                }

                C.Clear();
            }
            catch
            {
                MessageBox.Show("Введите второе число");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(textBox1.Text));
            button3.Enabled = false;
            label1.Text = textBox1.Text + " + ";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(textBox1.Text));
            button9.Enabled = false;
            label1.Text = textBox1.Text + " - ";
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(textBox1.Text));
            button10.Enabled = false;
            label1.Text = textBox1.Text + " * ";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(textBox1.Text));
            button14.Enabled = false;
            label1.Text = textBox1.Text + " / ";
            textBox1.Text = "";
        }

    }
}
