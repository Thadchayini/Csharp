using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(num1.Text)) {
                MessageBox.Show("Please Enter the number");
                num1.Focus();
                num1.BackColor = Color.Blue;
                return;
            }
            if (String.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please Enter the number");
                num2.Focus();
                num2.BackColor = Color.Blue;
                return;
            }

            decimal num11 = Convert.ToDecimal(num1.Text);
            decimal num22 = Convert.ToDecimal(num2.Text);
            decimal div = num11 / num22;
            result.Text = div.ToString();
            result.BackColor = Color.Purple;
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Please Enter the number");
                num1.Focus();
                num1.BackColor = Color.Blue;
                return;
            }
            if (String.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please Enter the number");
                num2.Focus();
                num2.BackColor = Color.Blue;
                return;
            }

            decimal num11 = Convert.ToDecimal(num1.Text);
            decimal num22 = Convert.ToDecimal(num2.Text);
            decimal sum = num11 + num22;
            result.Text = sum.ToString();
            result.BackColor = Color.Green;

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Please Enter the number");
                num1.Focus();
                num1.BackColor = Color.Blue;
                return;
            }
            if (String.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please Enter the number");
                num2.Focus();
                num2.BackColor = Color.Blue;
                return;
            }

            decimal num11 = Convert.ToDecimal(num1.Text);
            decimal num22 = Convert.ToDecimal(num2.Text);
            decimal sub = num11 - num22;
            result.Text = sub.ToString();
            result.BackColor = Color.Red;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(num1.Text)) {
                MessageBox.Show("Please Enter the number");
                num1.Focus();
                num1.BackColor = Color.Blue;
                return;
            }
            if (String.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please Enter the number");
                num2.Focus();
                num2.BackColor = Color.Blue;
                return;
            }

            decimal num11 = Convert.ToDecimal(num1.Text);
            decimal num22 = Convert.ToDecimal(num2.Text);
            decimal mul = num11 * num22;
            result.Text = mul.ToString();
            result.BackColor = Color.Yellow;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
