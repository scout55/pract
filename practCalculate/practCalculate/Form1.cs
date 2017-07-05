using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practCalculate.OneArgFactory;
using practCalculate.TwoArgFactory;

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

        private void buttonClickTwoArgs(object sender, EventArgs e)
        {
            numberFirst = Convert.ToDouble(textBox1.Text);
            numberSecond = Convert.ToDouble(textBox2.Text);
            ITwoArgCalc calculator = TwoArgumentsFactory.createCalculator(((Button)sender).Name);
            result = calculator.Calculate(numberFirst, numberSecond);
            label1.Text = Convert.ToString(result);
        }
        private void buttonClickOneArg(object sender, EventArgs e)
        {
            numberFirst = Convert.ToDouble(textBox1.Text);
            IOneArgCalc calculator = OneArgFactory.OneArgFactory.createCalculator(((Button)sender).Name);
            result = calculator.Calculate(numberFirst);
            label1.Text = Convert.ToString(result);
        }
    }
}
