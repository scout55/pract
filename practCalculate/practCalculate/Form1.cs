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
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {

            numberFirst = Convert.ToDouble(textBox1.Text);
            numberSecond = Convert.ToDouble(textBox2.Text);
            switch (((Button)sender).Name)
            {
                case "button1":
                    result = numberFirst + numberSecond;
                    break;
                case "button2":
                    result = numberFirst - numberSecond;
                    break;
                case "button3":
                    result = numberFirst * numberSecond;
                    break;
                case "button4":
                    result = numberFirst / numberSecond;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            label1.Text = Convert.ToString(result);
        }
    }
}
