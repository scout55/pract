using System;
using System.Windows.Forms;
using practCalculate.OneArg;
using practCalculate.TwoArg;

namespace practCalculate
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// freecodecamp.org
        /// </summary>
        double _numberFirst;
        double _numberSecond;
        double _result;

        public Form1()
        {
            InitializeComponent();
        }

        private void PressKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (((TextBox)sender).Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                }
                e.KeyChar = '.';
            }
            if (e.KeyChar == '-')
                if (((TextBox)sender).Text.IndexOf('-') != -1)
                    e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }


        private void ButtonClickTwoArgs(object sender, EventArgs e)
        {
            try
            {
                _numberFirst = Convert.ToDouble(textBox1.Text);
                _numberSecond = Convert.ToDouble(textBox2.Text);
                ITwoArgCalc calculator = TwoArgumentsFactory.createCalculator(((Button)sender).Name);
                _result = calculator.Calculate(_numberFirst, _numberSecond);
                label1.Text = _result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);

            }
        }


        private void ButtonClickOneArg(object sender, EventArgs e)
        {
            try
            {
                _numberFirst = Convert.ToDouble(textBox1.Text);
                IOneArgCalc calculator = OneArgFactory.createCalculator(((Button)sender).Name);
                _result = calculator.Calculate(_numberFirst);
                label1.Text = Convert.ToString(_result);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);

            }
        }
    }
}
