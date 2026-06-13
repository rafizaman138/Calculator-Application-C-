using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculetor
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        String CalTotal;
        int num1;
        int num2;
        String option;
        int result;


        private void btn1_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textTotal.Text);
            if (option == "+")
                result = num1 + num2;
            if (option == "-")
                result = num1 - num2;
            if (option == "*")
                result = num1 * num2;
            if (option == "/")
                result = num1 / num2;

            textTotal.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}
