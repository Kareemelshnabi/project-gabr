using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace gabr
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("pleasse, Enter values..", "message", MessageBoxButtons.OK);
                return;
            }


            double variable = double.Parse(textBox1.Text);
            double equation = double.Parse(textBox2.Text);
            if (variable > equation)
            {
                DialogResult dialogResult = MessageBox.Show("Homegenous System! Are the constants =0?"
                    , "message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Infinite number of soultions"!,"message", MessageBoxButtons.OK);
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Please , Enter the full equations then"!, "message", MessageBoxButtons.OK);
                }

                return;
            }
            else if (equation > (variable + 1))
            {

                MessageBox.Show("Invaild , Please enter a number of equations equal to the number of variables or greater than the number of variables by one ", "message", MessageBoxButtons.OK);
                return;
            }
          
            else if (variable == 4 && equation == 4)
            {
                //5*4
                design5x4 ds5x4=new design5x4();
                ds5x4.ShowDialog();

            }
            else if (variable == 4 && equation == 5)
            {
                Form22 frm2 = new Form22();
                //frm2.ShowDialog();     //5*5

            }
            else if (variable == 3 && equation == 3)
            {
                design3x4 design3x4=new design3x4();
                design3x4.ShowDialog();
                //4*3 
            }
            else if (variable == 3 && equation == 4)
            {
                design4x4 design4x4=new design4x4();
                design4x4.ShowDialog();
                //4*4
            }
          
            else if (variable == 2 && equation == 2)
            {
                //3*2
                design3x2 design3x2=new design3x2();
                design3x2.ShowDialog();
            }
            else if (variable == 2 && equation == 3)
            {
                //3*3
                design_3x3 design3X3 = new design_3x3();
                design3X3.ShowDialog();
            }
           // else if (variable == 2 && equation == 4)
           // {
                //3*4
          //  }
          
          
            else 
            {
                MessageBox.Show(" Max 4 variables.. and Min 2 variables! ");

                return;
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
