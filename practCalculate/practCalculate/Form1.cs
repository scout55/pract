using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practCalculate
{
    public partial class Form1 : Form
    {
        double numberFirst;
        double numberSecond;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            numberFirst = Convert.ToDouble(textBox1.Text);
            numberSecond = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(numberFirst + numberSecond);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberFirst = Convert.ToDouble(textBox1.Text);
            numberSecond = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(numberFirst - numberSecond);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberFirst = Convert.ToDouble(textBox1.Text);
            numberSecond = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(numberFirst * numberSecond);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberFirst = Convert.ToDouble(textBox1.Text);
            numberSecond = Convert.ToDouble(textBox2.Text);
            if (numberSecond == 0) label1.Text = "error";
            else label1.Text = Convert.ToString(numberFirst / numberSecond);
        }
    }
}
