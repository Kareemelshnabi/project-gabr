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
{
    public partial class sol3x2 : Form
    {
        public double num1;
        public double num2;
        
        public double num5;
        public double num6;
        
        public double num11;
        public double num12;
        
        public sol3x2(double num1,

            double num2,
           
            double num5,
            double num6,
          
            double num11,
            double num12
           )
        {
            InitializeComponent();
            this.num1 = num1;
            this.num2 = num2;
           
            this.num5 = num5;
            this.num6 = num6;
           
            this.num11 = num11;
            this.num12 = num12;
          
        }

        private void sol3x2_Load(object sender, EventArgs e)
        {
        p:
              if (num1 == 1)
            {

                label11.Text = num1.ToString();
                label12.Text = num5.ToString();
                label19.Text = num12.ToString();
                label8.Text = "Done";



            }
            else if (num1 != 0 && num1 != 1)
            {

                num5 = 1 / num1 * num5;
                num5 = Math.Round(num5, 2);
                label12.Text = num5.ToString();
                num12 = 1 / num1 * num12;
                num12 = Math.Round(num12, 2);
                label19.Text = num12.ToString();


                label8.Text = " R1*1/" + num1 + "-->R1";

                num1 = 1 / num1 * num1;
                num1 = Math.Round(num1, 2);
                label11.Text = num1.ToString();

               



            }
           
            else if (num1 == 0 && num2 != 0)
            {
                double enum1 = num1;
                double enum2 = num5;
                double enum3 = num12;
                

                double enum6 = num2;
                double enum7 = num6;
                double enum8 = num11;
                

                num1 = enum6;
                num5 = enum7;
                num12 = enum8;
                

                num2 = enum1;
                num6 = enum2;
                num11 = enum3;

                label8.Text = "Interchanging R1,R2";

                goto p;
            }



            if (num2 == 1 && num2 != 0)
            {
                num2 = num2 - num1;
                num2 = Math.Round(num2, 2);
                label10.Text = num2.ToString();

               

                num11 = num11 - num12;
                num11 = Math.Round(num11, 2);
                label18.Text = num11.ToString();
                num6 = num6 - num5;
                num6 = Math.Round(num6, 2);
                label13.Text = num6.ToString();
                goto y;

                label9.Text = "R2 - R1 -->R2";


            }

            else if (num2 == -1)
            {
                num2 = num2 + num1;
                num2 = Math.Round(num2, 2);
                label10.Text = num2.ToString();


              
                num11 = num11 + num12;
                num11 = Math.Round(num11, 2);
                label18.Text = num11.ToString();

                num6 = num6 + num5;
                num6 = Math.Round(num6, 2);
                label13.Text = num6.ToString();
                label9.Text = " R2 + R1 --> R2";
                goto y;
            }

            else if (num2 == 0)
            {
                label10.Text = num2.ToString();
                label13.Text = num6.ToString();
                label18.Text = num11.ToString();

                label9.Text = "Done";
                goto y;
            }
            else if (num2 != 0 && num2 != 1)
            {

                num6 = 1 / num2 * num6;
                num6 = Math.Round(num6, 2);
                num6 = num6 - num5;
                num6 = Math.Round(num6, 2);

                num11 = 1 / num2 * num11;
                num11 = Math.Round(num11, 2);
                num11 = num11 - num12;
                num11 = Math.Round(num11, 2);

                label9.Text = "R2*1/" + num2 + "-->R2. && R2 - R1 -->R2";


                num2 = 1 / num2 * num2;
                num2 = Math.Round(num2, 2);
                num2 = num2 - num1;
                num2 = Math.Round(num2, 2);

                label10.Text = num2.ToString();
                label13.Text = num6.ToString();
                label18.Text = num11.ToString();

               
                goto y;
            }
        y:



         
            label48.Text = num1.ToString();

            label34.Text = num5.ToString();

            label35.Text = num12.ToString();

           



       

            if (num6 == 1)
            {
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
                  label10.Text="Done";

                
            }
            else if (num6 != 0 && num6 != 1)
            {
                num11 = 1 / num6 * num11;
                num11 = Math.Round(num11, 2);
                  label14.Text= " R2*1/" + num6 + "-->R2";

                num6 = 1 / num6 * num6;
                num6 = Math.Round(num6, 2);
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
              
                
            }
             if (num6 == 0 &&num11==0&&num5==0)
            {
               double x=double.Parse(label35.Text);
                double y = double.Parse(label48.Text);
                double z = x / y;
                z = Math.Round(z, 1);
                label89.Text=z.ToString();
                label90.Text="";
                label155.Text = "Infinity soulution";
                 label14.Text="";


            }else if (num6 == 0 && num11 == 0 && num5 != 0)
            {
                label89.Text = "";
               label90.Text = "";
                label155.Text = "Infinity soulution";
                 label14.Text="";
            }else if (num6 == 0 && num11 != 0)
            {
                label155.Text = "No SOULUTION";
                label89.Text = "";
                label90.Text = "";
                 label14.Text="";
            }else if (num6 != 0 )
            {
              

                double w = double.Parse(label36.Text);
                double s = double.Parse(label33.Text);
                double q = w/s;
                q = Math.Round(q, 1);
                label90.Text =q.ToString() ;
                label155.Text = "";
                double x = double.Parse(label34.Text);

                double a = double.Parse(label35.Text);
                double b = double.Parse(label48.Text);

                double z = (a - (x * q)) / b;
                z = Math.Round(z, 1);
                label89.Text = z.ToString();
                 label14.Text="";

            }

        


          
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
