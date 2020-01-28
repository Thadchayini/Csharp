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
    public partial class formfirst : Form
    {
        public formfirst()
        {
            InitializeComponent();
        }

        private void formfirst_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textbox.Text);
            //textbox1.Text = textbox.Text;
            if (String.IsNullOrEmpty(textbox.Text))
            {
                MessageBox.Show("Please Enter first name");
                textbox.Focus();
                textbox.BackColor = Color.Pink;
                return;
            }
            else {
                textbox.BackColor = Color.White;
            }
            //textbox2.Text = textbox.Text + textbox1.Text;
        }
        
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void textbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //textbox1.Text = textbox.Text;
        }
    }
}
