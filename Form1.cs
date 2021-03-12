using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void button0_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "2";
        }

        private void periodButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += ".";
        }

        private void equalButton_MouseClick(object sender, MouseEventArgs e)
        {
            var result = calculate(textBox1.Text);
            textBox1.Text += " = " + result.ToString();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void subtractButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void multiplyButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void divideButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void closeParenthesis_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += ")";
        }

        private void openParenthesis_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "(";
        }

        private void clearButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private object calculate(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(text, "");
            }
            catch(Exception e)
            {
                v = e.StackTrace;
            }
            return v;
        }
    }
}
