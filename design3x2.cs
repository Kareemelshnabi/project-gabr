using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gabr
    hapyyyyyy
{
    public partial class design3x2 : Form
    {
        public design3x2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void design3x2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" 
               || textBox5.Text == "" || textBox6.Text == "" 
               || textBox11.Text == "" || textBox12.Text == ""
               )
            {
                MessageBox.Show("Please Enter the all values ", "Message", MessageBoxButtons.OK);
                return;

            }
            if (textBox1.Text=="0"&&textBox5.Text=="0"&&textBox12.Text=="0"|| textBox2.Text == "0" && textBox6.Text == "0" && textBox11.Text == "0")
            {

                MessageBox.Show("The system has Infinite number of solutions!", "Message", MessageBoxButtons.OK);
                return;
            }
            else if (textBox1.Text == "0" && textBox5.Text == "0" && textBox12.Text != "0" || textBox2.Text == "0" && textBox6.Text == "0" && textBox11.Text != "0")
            {
                MessageBox.Show("The system has no solutions!", "Message", MessageBoxButtons.OK);
                return;
            }


            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
           
            double num5 = double.Parse(textBox5.Text);
            double num6 = double.Parse(textBox6.Text);
           
            double num11 = double.Parse(textBox11.Text);
            double num12 = double.Parse(textBox12.Text);
          






            sol3x2 sol3x2 = new sol3x2(num1, num2, num5, num6, 
                  num11, num12);
            sol3x2.ShowDialog();



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //to restrict the user to input only digits
            {
                e.Handled = true;
            }
        }
    }
    }

