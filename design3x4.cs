﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gabr 
    happy
{
    public partial class design3x4 : Form
    {
        public design3x4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" 
              || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""
              || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""
              || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" )
            {
                MessageBox.Show("Please Enter the all values ", "Message", MessageBoxButtons.OK);
                return;

            }
            if ( textBox3.Text == "0" && textBox7.Text == "0" && textBox10.Text == "0" && textBox15.Text == "0" || textBox2.Text == "0" && textBox6.Text == "0" && textBox11.Text == "0" && textBox14.Text == "0" || textBox1.Text == "0" && textBox5.Text == "0" && textBox12.Text == "0" && textBox13.Text == "0")
            {

                MessageBox.Show("The system has Infinite number of solutions!", "Message", MessageBoxButtons.OK);
                return;
            }
            else if ( textBox3.Text == "0" && textBox7.Text == "0" && textBox10.Text == "0" && textBox15.Text != "0" || textBox2.Text == "0" && textBox6.Text == "0" && textBox11.Text == "0" && textBox14.Text != "0" || textBox1.Text == "0" && textBox5.Text == "0" && textBox12.Text == "0" && textBox13.Text != "0")
            {
                MessageBox.Show("The system has no solutions!", "Message", MessageBoxButtons.OK);
                return;
            }


            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double num3 = double.Parse(textBox3.Text);
            
            double num5 = double.Parse(textBox5.Text);
            double num6 = double.Parse(textBox6.Text);
            double num7 = double.Parse(textBox7.Text);
            
            
            double num10 = double.Parse(textBox10.Text);
            double num11 = double.Parse(textBox11.Text);
            double num12 = double.Parse(textBox12.Text);
            double num13 = double.Parse(textBox13.Text);
            double num14 = double.Parse(textBox14.Text);
            double num15 = double.Parse(textBox15.Text);
            






            sol3x4 sol3x4= new sol3x4(num1, num2, num3,  num5, num6, num7, 
                 num10, num11, num12, num13, num14, num15);
            sol3x4.ShowDialog();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }

    }
}
