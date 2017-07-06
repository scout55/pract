using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practCalculate.OneArg;
using practCalculate.TwoArg;

namespace practCalculate
{
    public partial class Form1 : Form
    {
        double _numberFirst;
        double _numberSecond;
        double _result;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClickTwoArgs(object sender, EventArgs e)
        {
            _numberFirst = Convert.ToDouble(textBox1.Text);
            _numberFirst = Convert.ToDouble(textBox2.Text);
            ITwoArgCalc calculator = TwoArgumentsFactory.createCalculator(((Button)sender).Name);
            _result = calculator.Calculate(_numberFirst, _numberFirst);
            label1.Text = Convert.ToString(_result);
        }
        private void buttonClickOneArg(object sender, EventArgs e)
        {
            _numberFirst = Convert.ToDouble(textBox1.Text);
            IOneArgCalc calculator = OneArgFactory.createCalculator(((Button)sender).Name);
            _result = calculator.Calculate(_numberFirst);
            label1.Text = Convert.ToString(_result);
        }
    }
}
