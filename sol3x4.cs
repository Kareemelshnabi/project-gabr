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
    public partial class sol3x4 : Form
    {
        public double num1;
        public double num2;
        public double num3;
        
        public double num5;
        public double num6;
        public double num7;
        
        
        public double num10;
        public double num11;
        public double num12;
        public double num13;
        public double num14;
        public double num15;
       
        public sol3x4(double num1,

            double num2,
            double num3,
           
            double num5,
            double num6,
            double num7,
            
            
            double num10,
            double num11,
            double num12,
            double num13,
            double num14,
            double num15
            )
        {
            InitializeComponent();
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num5 = num5;
            this.num6 = num6;
            this.num7 = num7;
            this.num10 = num10;
            this.num11 = num11;
            this.num12 = num12;
            this.num13 = num13;
            this.num14 = num14;
            this.num15 = num15;
                

        }

        private void sol3x4_Load(object sender, EventArgs e)
        {
        p:
            if (num1 != 0 && num1 != 1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -"+num3+"R1+R3-->R3";

                num5 = 1 / num1 * num5;
                num5 = Math.Round(num5, 2);
                label12.Text = num5.ToString();
                num12 = 1 / num1 * num12;
                num12 = Math.Round(num12, 2);
                label19.Text = num12.ToString();
                num13 = 1 / num1 * num13;
                num13 = Math.Round(num13, 2);
                label20.Text = num12.ToString();



                num1 = 1 / num1 * num1;
                num1 = Math.Round(num1, 2);
                label11.Text = num1.ToString();





            }
            else if (num1 == 1)
            {
                label5.Text = "Done";
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                label11.Text = num1.ToString();
                label12.Text = num5.ToString();
                label19.Text = num12.ToString();
                label20.Text = num12.ToString();


            }
            else if (num1 == 0 && num2 != 0)
            {
                label5.Text = "Interchanging R1,R2  R1/"+num2;
                label6.Text =  "done, -" + num3 + "R1+R3-->R3";
                double enum1 = num1;
                double enum2 = num5;
                double enum3 = num12;
                double enum4 = num13;

                double enum6 = num2;
                double enum7 = num6;
                double enum8 = num11;
                double enum9 = num14;

                num1 = enum6;
                num5 = enum7;
                num12 = enum8;
                num13 = enum9;

                num2 = enum1;
                num6 = enum2;
                num11 = enum3;
                num14 = enum4;


                goto p;
            }



            if (num2 == 1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                num2 = num2 - num1;
                num2 = Math.Round(num2, 2);
                label10.Text = num2.ToString();

                num14 = num14 - num13;
                num14 = Math.Round(num14, 2);
                label21.Text = num14.ToString();

                num11 = num11 - num12;
                num11 = Math.Round(num11, 2);
                label18.Text = num11.ToString();
                num6 = num6 - num5;
                num6 = Math.Round(num6, 2);
                label13.Text = num6.ToString();
                




            }

            else if (num2 == -1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                num2 = num2 + num1;
                num2 = Math.Round(num2, 2);
                label10.Text = num2.ToString();


                num14 = num14 + num13;
                num14 = Math.Round(num14, 2);
                label21.Text = num14.ToString();

                num11 = num11 + num12;
                num11 = Math.Round(num11, 2);
                label18.Text = num11.ToString();

                num6 = num6 + num5;
                num6 = Math.Round(num6, 2);
                label13.Text = num6.ToString();

                
            }

            else if (num2 == 0)
            {
                label10.Text = num2.ToString();
                label13.Text = num6.ToString();
                label18.Text = num11.ToString();
                label21.Text = num14.ToString();

               
            }
            else if (num2 != 0 && num2 != 1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                num6 = 1 / num2 * num6;
                num6 = Math.Round(num6, 2);
                num6 = num6 - num5;
                num6 = Math.Round(num6, 2);

                num11 = 1 / num2 * num11;
                num11 = Math.Round(num11, 2);
                num11 = num11 - num12;
                num11 = Math.Round(num11, 2);

                num14 = 1 / num2 * num14;
                num14 = Math.Round(num14, 2);
                num14 = num14 - num13;
                num14 = Math.Round(num14, 2);


                num2 = 1 / num2 * num2;
                num2 = Math.Round(num2, 2);
                num2 = num2 - num1;
                num2 = Math.Round(num2, 2);

                label10.Text = num2.ToString();
                label13.Text = num6.ToString();
                label18.Text = num11.ToString();
                label21.Text = num14.ToString();

                
            }
       



            if (num3 == 1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                num7 = num7 - num5;
                num7 = Math.Round(num7, 2);

                num10 = num10 - num12;
                num10 = Math.Round(num10, 2);

                num15 = num15 - num13;
                num15 = Math.Round(num15, 2);

                num3 = num3 - num1;
                num3 = Math.Round(num3, 2);

                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();

                
            }
            else if (num3 == -1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                num7 = num7 + num5;
                num7 = Math.Round(num7, 2);
                num10 = num10 + num12;
                num10 = Math.Round(num10, 2);
                num15 = num15 + num13;
                num15 = Math.Round(num15, 2);

                num3 = num3 + num1;
                num3 = Math.Round(num3, 2);
                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();

                
            }

            else if (num3 == 0)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2 ,R3 Done" ;
                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();

                
            }
            else if (num3 != 0 && num3 != 1)
            {
                label5.Text = "R1/" + num1;
                label6.Text = "-" + num2 + "R1+R2-->R2, -" + num3 + "R1+R3-->R3";
                num7 = 1 / num3 * num7;
                num7 = Math.Round(num7, 2);
                num7 = num7 - num5;
                num7 = Math.Round(num7, 2);

                num10 = 1 / num3 * num10;
                num10 = Math.Round(num10, 2);
                num10 = num10 - num12;
                num10 = Math.Round(num10, 2);

                num15 = 1 / num3 * num15;
                num15 = Math.Round(num15, 2);
                num15 = num15 - num13;
                num15 = Math.Round(num15, 2);

                num3 = 1 / num3 * num3;
                num3 = Math.Round(num3, 2);
                num3 = num3 - num1;
                num3 = Math.Round(num3, 2);
                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();

                
            }
        


          
            label48.Text = num1.ToString();

            label34.Text = num5.ToString();

            label35.Text = num12.ToString();

            label42.Text = num13.ToString();



        b:

            if (num6 == 1)
            {
                label4.Text = "Done";
                label8.Text = "-" + num7 + "R2+R3-->R3";
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
                label41.Text = num14.ToString();

                
            }
            else if (num6 != 0 && num6 != 1)
            {
                label4.Text = "R2/" + num6; ;
                label8.Text = "-" + num7 + "R2+R3-->R3";
                num11 = 1 / num6 * num11;
                num11 = Math.Round(num11, 2);
                num14 = 1 / num6 * num14;
                num14 = Math.Round(num14, 2);

                num6 = 1 / num6 * num6;
                num6 = Math.Round(num6, 2);
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
                label41.Text = num14.ToString();

                
            }
            else if (num6 == 0 && num7 != 0)
            {
                label4.Text = "Interchanging R2,R3,   R2/"+num7;
                label8.Text = "Done";
                double numx6 = num6;
                double numx7 = num11;
                double numx8 = num14;

                double numx10 = num7;
                double numx11 = num10;
                double numx12 = num15;

                num7 = numx6;
                num10 = numx7;
                num15 = numx8;

                num6 = numx10;
                num11 = numx11;
                num14 = numx12;

                goto b;
            }

        


            if (num7 == 1)
            {
                label4.Text = "R2 /" + num6;
                label8.Text = "-" + num7 + "R2+R3-->R3";
                num10 = num10 - num11;
                num10 = Math.Round(num10, 2);
                num15 = num15 - num14;
                num15 = Math.Round(num15, 2);

                num7 = num7 - num6;
                num7 = Math.Round(num7, 2);

                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();


                
            }
            else if (num7 == -1)
            {
                label4.Text = "R2 /" + num6;
                label8.Text = "-" + num7 + "R2+R3-->R3";
                num10 = num10 + num11;
                num10 = Math.Round(num10, 2);
                num15 = num15 + num14;
                num15 = Math.Round(num15, 2);

                num7 = num7 + num6;
                num7 = Math.Round(num7, 2);
                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();

               
            }


            else if (num7 == 0)
            {
                label4.Text = "R2 /" + num6;
                label8.Text = "Done";

                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();

                

            }
            else if (num7 != 0 && num7 != 1)
            {

                label4.Text = "R2 /" + num6;
                label8.Text = "-" + num7 + "R2+R3-->R3";
                num10 = 1 / num7 * num10;
                num10 = Math.Round(num10, 2);
                num10 = num10 - num11;
                num10 = Math.Round(num10, 2);
                num15 = 1 / num7 * num15;
                num15 = Math.Round(num15, 2);
                num15 = num15 - num14;
                num15 = Math.Round(num15, 2);

                num7 = 1 / num7 * num7;
                num7 = Math.Round(num7, 2);
                num7 = num7 - num6;
                num7 = Math.Round(num7, 2);

                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();

                
            }
        


           
            label69.Text = num1.ToString();
            label76.Text = num5.ToString();
            label77.Text = num12.ToString();
            label84.Text = num13.ToString();

            label70.Text = num2.ToString();
            label75.Text = num6.ToString();
            label78.Text = num11.ToString();
            label83.Text = num14.ToString();


            label71.Text = num3.ToString();
            label74.Text = num7.ToString();

           

            if (num10 == 1)
            {
                label15.Text = "Done";
                label82.Text = num15.ToString();
                label79.Text = num10.ToString();

            }
            else if (num10 != 1 && num10 != 0)
            {
                label15.Text = "R3/" + num10;
               
                num15 = 1 / num10 * num15;
                num15 = Math.Round(num15, 2);
                label82.Text = num15.ToString();


                num10 = 1 / num10 * num10;
                num10 = Math.Round(num10, 2);
                label79.Text = num10.ToString();



            }else if(num10 == 0 && num15 == 0&&num11!=0)
            {
                label15.Text = "";
                label89.Text = "";
                label90.Text = "";
                label91.Text = "";
                label155.Text = "Infinity soulution..";
            }else if (num10 == 0 && num15 != 0)
            {
                label15.Text = "";
                label89.Text = "";
                label90.Text = "";
                label91.Text = "";
                label155.Text = "NO SOULUTION..";
            }
           if (num10 == 1)
            {
               
                label15.Text = "Done";
                double x=double.Parse(num15.ToString());
                double y=double.Parse(num10.ToString());
                double z = x / y ;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                z = Math.Round(z, 1);
                double q=double.Parse(num14.ToString());
                double r=double.Parse(num11.ToString());
                double s=double.Parse(num6.ToString());
                double t = (q - (r * z)) / s;
                t = Math.Round(t, 1);
                label90.Text = t.ToString();

                double v = double.Parse(num13.ToString());
                double b = double.Parse(num12.ToString());
                double n = double.Parse(num5.ToString());
                double m = double.Parse(num1.ToString());
                double l = (v - (b * z) - (n * t)) / m;
                l = Math.Round(l, 1);
                label89.Text = l.ToString();
                label155.Text = "";

            }else if (num10 == 0 && num15 == 0 && num11 == 0&&num12==0)
            {
                label15.Text = "";
                double x = double.Parse(num14.ToString());
                double y = double.Parse(num6.ToString());
                double z = x / y;
                z = Math.Round(z, 1);
                label90.Text = z.ToString();

                double q = double.Parse(num13.ToString());
                double r = double.Parse(num5.ToString());
                double s = double.Parse(num1.ToString());
                double t = (q - (r * z)) / s;
                t = Math.Round(t, 1);
                label89.Text = t.ToString();
                label155.Text = "Infinity soulution..";
                label91.Text = "";

            }
           else if (num10 == 0 && num15 == 0 && num11 == 0 && num12 != 0)
            {
                label15.Text = "";
                double x = double.Parse(num14.ToString());
                double y = double.Parse(num6.ToString());
                double z = x / y;
                z = Math.Round(z, 1);
                label90.Text = z.ToString();
                label155.Text = "Infinity soulution..";
                label91.Text = "";
                label89.Text = "";

            }
            else if (num10 == 0 && num15 == 0 && num11 != 0 && num12 == 0&&num5==0)
            {
                label15.Text = "";
                double x = double.Parse(num13.ToString());
                double y = double.Parse(num1.ToString());
                double z = x / y;
                z = Math.Round(z, 1);
                label89.Text = z.ToString();
                label155.Text = "Infinity soulution..";
                label91.Text = "";
                label90.Text = "";

            }

        }

    }
}
