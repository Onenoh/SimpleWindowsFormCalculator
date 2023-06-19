using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operationalSign = string.Empty;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
                textBox_result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text += button.Text;
                }
            }
            else
            {
                textBox_result.Text += button.Text;
            }

        }

        private void Operational_button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationalSign = button.Text;
            result = Double.Parse(textBox_result.Text);
            currentDisplay.Text = result + " " + operationalSign;
            isOperationPerformed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            currentDisplay.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // textBox_result.Text = "0";
            var text = textBox_result.Text;
            textBox_result.Text = text.Remove(text.Length - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operationalSign)
            {
                case "+":
                    textBox_result.Text = (result + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (result - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (result * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (result / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox_result.Text);
            currentDisplay.Text = "";
        }
    }
}
