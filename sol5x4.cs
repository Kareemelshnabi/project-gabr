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
    public partial class sol5x4 : Form
    {
        public double num1;
        public double num2;
        public double num3;
        public double num4;
        public double num5;
        public double num6;
        public double num7;
        public double num8;
        public double num9;
        public double num10;
        public double num11;
        public double num12;
        public double num13;
        public double num14;
        public double num15;
        public double num16;
        public double num17;
        public double num18;
        public double num19;
        public double num20;
        public sol5x4(double num1,

 double num2,
 double num3,
 double num4,
 double num5,
 double num6,
 double num7,
 double num8,
 double num9,
 double num10,
 double num11,
 double num12,
 double num13,
 double num14,
 double num15,
 double num16,
 double num17,
 double num18,
 double num19,
 double num20)
        {
            InitializeComponent();

            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.num5 = num5;
            this.num6 = num6;
            this.num7 = num7;
            this.num8 = num8;
            this.num9 = num9;
            this.num10 = num10;
            this.num11 = num11;
            this.num12 = num12;
            this.num13 = num13;
            this.num14 = num14;
            this.num15 = num15;
            this.num16 = num16;
            this.num17 = num17;
            this.num18 = num18;
            this.num19 = num19;
            this.num20 = num20;
        }

        private void sol5x4_Load(object sender, EventArgs e)
        {

        p:
            if (num1 != 0 && num1 != 1)
            {

                num5 = 1 / num1 * num5;
                num5 = Math.Round(num5, 2);
                label12.Text = num5.ToString();
                num12 = 1 / num1 * num12;
                num12 = Math.Round(num12, 2);
                label19.Text = num12.ToString();
                num13 = 1 / num1 * num13;
                num13 = Math.Round(num13, 2);
                label20.Text = num13.ToString();
                num20 = 1 / num1 * num20;
                num20 = Math.Round(num20, 2);
                label24.Text = num20.ToString();
                num1 = 1 / num1 * num1;
                num1 = Math.Round(num1, 2);
                label11.Text = num1.ToString();

                goto x;



            }
            else if (num1 == 1)
            {
                label12.Text = num5.ToString();
                label19.Text = num12.ToString();
                label20.Text = num13.ToString();
                label24.Text = num20.ToString();
                label11.Text = num1.ToString();
                goto x;
            }
            else if (num1 == 0 && num2 != 0)
            {
                double enum1 = num1;
                double enum2 = num5;
                double enum3 = num12;
                double enum4 = num13;
                double enum5 = num20;
                double enum6 = num2;
                double enum7 = num6;
                double enum8 = num11;
                double enum9 = num14;
                double enum10 = num19;
                num1 = enum6;
                num5 = enum7;
                num12 = enum8;
                num13 = enum9;
                num20 = enum10;
                num2 = enum1;
                num6 = enum2;
                num11 = enum3;
                num14 = enum4;
                num19 = enum5;

                goto p;




            }

        x:

            if (num2 == 1 && num2 != 0)
            {
                num2 = num2 - num1;
                num2 = Math.Round(num2, 2);
                label10.Text = num2.ToString();
                num19 = num19 - num20;
                num19 = Math.Round(num19, 2);
                label25.Text = num19.ToString();
                num14 = num14 - num13;
                num14 = Math.Round(num14, 2);
                label21.Text = num14.ToString();
                num11 = num11 - num12;
                num11 = Math.Round(num11, 2);
                label18.Text = num11.ToString();
                num6 = num6 - num5;
                num6 = Math.Round(num6, 2);
                label13.Text = num6.ToString();
                goto y;




            }

            else if (num2 == -1)
            {
                num2 = num2 + num1;
                num2 = Math.Round(num2, 2);
                label10.Text = num2.ToString();
                num19 = num19 + num20;
                num19 = Math.Round(num19, 2);
                label25.Text = num19.ToString();
                num14 = num14 + num13;
                num14 = Math.Round(num14, 2);
                label21.Text = num14.ToString();
                num11 = num11 + num12;
                num11 = Math.Round(num11, 2);
                label18.Text = num11.ToString();

                num6 = num6 + num5;
                num6 = Math.Round(num6, 2);
                label13.Text = num6.ToString();

                goto y;
            }

            else if (num2 == 0)
            {
                label10.Text = num2.ToString();
                label13.Text = num6.ToString();
                label18.Text = num11.ToString();
                label21.Text = num14.ToString();
                label25.Text = num19.ToString();
                goto y;
            }
            else if (num2 != 0 && num2 != 1)
            {

                num6 = 1 / num2 * num6;
                num6 = Math.Round(num6, 2);
                num6 = num6 - num5;
                num11 = 1 / num2 * num11;
                num11 = Math.Round(num11, 2);
                num11 = num11 - num12;

                num14 = 1 / num2 * num14;
                num14 = Math.Round(num14, 2);
                num14 = num14 - num13;

                num19 = 1 / num2 * num19;
                num19 = Math.Round(num19, 2);
                num19 = num19 - num20;

                num2 = 1 / num2 * num2;
                num2 = num2 - num1;
                num2 = Math.Round(num2, 2);

                label10.Text = num2.ToString();
                label13.Text = num6.ToString();
                label18.Text = num11.ToString();
                label21.Text = num14.ToString();
                label25.Text = num19.ToString();
                goto y;
            }
        y:



            if (num3 == 1)
            {
                num7 = num7 - num5;
                num7 = Math.Round(num7, 2);
                num10 = num10 - num12;
                num10 = Math.Round(num10, 2);
                num15 = num15 - num13;
                num15 = Math.Round(num15, 2);
                num18 = num18 - num20;
                num18 = Math.Round(num18, 2);
                num3 = num3 - num1;
                num3 = Math.Round(num3, 2);

                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();
                label26.Text = num18.ToString();
                goto z;
            }
            else if (num3 == -1)
            {
                num7 = num7 + num5;
                num7 = Math.Round(num7, 2);
                num10 = num10 + num12;
                num10 = Math.Round(num10, 2);
                num15 = num15 + num13;
                num15 = Math.Round(num15, 2);
                num18 = num18 + num20;
                num18 = Math.Round(num18, 2);
                num3 = num3 + num1;
                num3 = Math.Round(num3, 2);
                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();
                label26.Text = num18.ToString();
                goto z;
            }

            else if (num3 == 0)
            {
                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();
                label26.Text = num18.ToString();
                goto z;
            }
            else if (num3 != 0 && num3 != 1)
            {

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
                num18 = 1 / num3 * num18;
                num18 = Math.Round(num18, 2);
                num18 = num18 - num20;
                num18 = Math.Round(num18, 2);
                num3 = 1 / num3 * num3;
                num3 = Math.Round(num3, 2);
                num3 = num3 - num1;
                num3 = Math.Round(num3, 2);
                label9.Text = num3.ToString();
                label14.Text = num7.ToString();
                label17.Text = num10.ToString();
                label22.Text = num15.ToString();
                label26.Text = num18.ToString();
                goto z;
            }
        z:


            if (num4 == 1)
            {
                num8 = num8 - num5;
                num8 = Math.Round(num8, 2);
                num9 = num9 - num12;
                num9 = Math.Round(num9, 2);
                num16 = num16 - num13;
                num16 = Math.Round(num16, 2);
                num17 = num17 - num20;
                num17 = Math.Round(num17, 2);
                num4 = num4 - num1;
                num4 = Math.Round(num4, 2);
                label8.Text = num4.ToString();
                label15.Text = num8.ToString();
                label16.Text = num9.ToString();
                label23.Text = num16.ToString();
                label27.Text = num17.ToString();
                goto x1;
            }

            else if (num4 == -1)
            {
                num8 = num8 + num5;
                num8 = Math.Round(num8, 2);
                num9 = num9 + num12;
                num9 = Math.Round(num9, 2);
                num16 = num16 + num13;
                num16 = Math.Round(num16, 2);
                num17 = num17 + num20;
                num17 = Math.Round(num17, 2);
                num4 = num4 + num1;
                num4 = Math.Round(num4, 2);
                label8.Text = num4.ToString();
                label15.Text = num8.ToString();
                label16.Text = num9.ToString();
                label23.Text = num16.ToString();
                label27.Text = num17.ToString();
                goto x1;
            }


            else if (num4 == 0)
            {

                label8.Text = num4.ToString();
                label15.Text = num8.ToString();
                label16.Text = num9.ToString();
                label23.Text = num16.ToString();
                label27.Text = num17.ToString();

                goto x1;
            }
            else if (num4 != 0 && num4 != 1)
            {

                num8 = 1 / num4 * num8;
                num8 = Math.Round(num8, 2);
                num8 = num8 - num5;
                num8 = Math.Round(num8, 2);
                num9 = 1 / num4 * num9;
                num9 = Math.Round(num9, 2);
                num9 = num9 - num12;
                num9 = Math.Round(num9, 2);

                num16 = 1 / num4 * num16;
                num16 = Math.Round(num16, 2);
                num16 = num16 - num13;
                num16 = Math.Round(num16, 2);
                num17 = 1 / num4 * num17;
                num17 = Math.Round(num17, 2);
                num17 = num17 - num20;
                num17 = Math.Round(num17, 2);
                num4 = 1 / num4 * num4;
                num4 = Math.Round(num4, 2);
                num4 = num4 - num1;
                num4 = Math.Round(num4, 2);
                label8.Text = num4.ToString();
                label15.Text = num8.ToString();
                label16.Text = num9.ToString();
                label23.Text = num16.ToString();
                label27.Text = num17.ToString();
                goto x1;
            }

        x1:
            label48.Text = num1.ToString();

            label34.Text = num5.ToString();

            label35.Text = num12.ToString();

            label42.Text = num13.ToString();

            label43.Text = num20.ToString();

        b:

            if (num6 == 1)
            {
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
                label41.Text = num14.ToString();
                label44.Text = num19.ToString();
                goto x2;
            }
            else if (num6 != 0 && num6 != 1 && num6 != -1)
            {
                num11 = 1 / num6 * num11;
                num11 = Math.Round(num11, 2);
                num14 = 1 / num6 * num14;
                num14 = Math.Round(num14, 2);
                num19 = 1 / num6 * num19;
                num19 = Math.Round(num19, 2);
                num6 = 1 / num6 * num6;
                num6 = Math.Round(num6, 2);
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
                label41.Text = num14.ToString();
                label44.Text = num19.ToString();
                goto x2;
            }
            else if (num6 == -1)
            {
                num11 = num11 / -1;
                num11 = Math.Round(num11, 2);
                num14 = num14 / -1;
                num14 = Math.Round(num14, 2);
                num19 = num19 / -1;
                num19 = Math.Round(num19, 2);
                num6 = num6 / -1;
                num6 = Math.Round(num6, 2);
                label28.Text = num2.ToString();
                label33.Text = num6.ToString();
                label36.Text = num11.ToString();
                label41.Text = num14.ToString();
                label44.Text = num19.ToString();
                goto x2;
            }
            else if (num6 == 0 && num7 != 0)
            {
                double numx6 = num6;
                double numx7 = num11;
                double numx8 = num14;
                double numx9 = num19;
                double numx10 = num7;
                double numx11 = num10;
                double numx12 = num15;
                double numx13 = num18;
                num7 = numx6;
                num10 = numx7;
                num15 = numx8;
                num18 = numx9;
                num6 = numx10;
                num11 = numx11;
                num14 = numx12;
                num19 = numx13;
                goto b;
            }

        x2:


            if (num7 == 1)
            {
                num10 = num10 - num11;
                num10 = Math.Round(num10, 2);
                num15 = num15 - num14;
                num15 = Math.Round(num15, 2);
                num18 = num18 - num19;
                num18 = Math.Round(num18, 2);
                num7 = num7 - num6;
                num7 = Math.Round(num7, 2);

                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();
                label45.Text = num18.ToString();

                goto x3;
            }
            else if (num7 == -1)
            {
                num10 = num10 + num11;
                num10 = Math.Round(num10, 2);
                num15 = num15 + num14;
                num15 = Math.Round(num15, 2);
                num18 = num18 + num19;
                num18 = Math.Round(num18, 2);
                num7 = num7 + num6;
                num7 = Math.Round(num7, 2);
                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();
                label45.Text = num18.ToString();
                goto x3;
            }


            else if (num7 == 0)
            {

                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();
                label45.Text = num18.ToString();
                goto x3;

            }
            else if (num7 != 0 && num7 != 1)
            {


                num10 = 1 / num7 * num10;
                num10 = Math.Round(num10, 2);
                num10 = num10 - num11;
                num10 = Math.Round(num10, 2);
                num15 = 1 / num7 * num15;
                num15 = Math.Round(num15, 2);
                num15 = num15 - num14;
                num15 = Math.Round(num15, 2);
                num18 = 1 / num7 * num18;
                num18 = Math.Round(num18, 2);
                num18 = num18 - num19;
                num18 = Math.Round(num18, 2);
                num7 = 1 / num7 * num7;
                num7 = Math.Round(num7, 2);
                num7 = num7 - num6;
                num7 = Math.Round(num7, 2);

                label29.Text = num3.ToString();
                label32.Text = num7.ToString();
                label37.Text = num10.ToString();
                label40.Text = num15.ToString();
                label45.Text = num18.ToString();
                goto x3;
            }
        x3:


            if (num8 == 1)
            {
                num9 = num9 - num11;
                num9 = Math.Round(num9, 2);
                num16 = num16 - num14;
                num16 = Math.Round(num16, 2);
                num17 = num17 - num19;
                num17 = Math.Round(num17, 2);
                num8 = num8 - num6;
                num8 = Math.Round(num8, 2);
                label30.Text = num4.ToString();
                label31.Text = num8.ToString();
                label38.Text = num9.ToString();
                label39.Text = num16.ToString();
                label46.Text = num17.ToString();
                goto x4;
            }
            else if (num8 == -1)
            {
                num9 = num9 + num11;
                num9 = Math.Round(num9, 2);
                num16 = num16 + num14;
                num16 = Math.Round(num16, 2);
                num17 = num17 + num19;
                num17 = Math.Round(num17, 2);
                num8 = num8 + num6;
                num8 = Math.Round(num8, 2);
                label30.Text = num4.ToString();
                label31.Text = num8.ToString();
                label38.Text = num9.ToString();
                label39.Text = num16.ToString();
                label46.Text = num17.ToString();
                goto x4;
            }


            else if (num8 == 0)
            {
                label30.Text = num4.ToString();
                label31.Text = num8.ToString();
                label38.Text = num9.ToString();
                label39.Text = num16.ToString();
                label46.Text = num17.ToString();

                goto x4;
            }
            else if (num8 != 0 && num8 != 1)
            {


                num9 = 1 / num8 * num9;
                num9 = Math.Round(num9, 2);
                num9 = num9 - num11;
                num9 = Math.Round(num9, 2);
                num16 = 1 / num8 * num16;
                num16 = Math.Round(num16, 2);
                num16 = num16 - num14;
                num16 = Math.Round(num16, 2);
                num17 = 1 / num8 * num17;
                num17 = Math.Round(num17, 2);
                num17 = num17 - num19;
                num17 = Math.Round(num17, 2);
                num8 = 1 / num8 * num8;
                num8 = Math.Round(num8, 2);
                num8 = num8 - num6;
                num8 = Math.Round(num8, 2);


                label30.Text = num4.ToString();
                label31.Text = num8.ToString();
                label38.Text = num9.ToString();
                label39.Text = num16.ToString();
                label46.Text = num17.ToString();

                goto x4;
            }

        x4:


            label69.Text = num1.ToString();
            label76.Text = num5.ToString();
            label77.Text = num12.ToString();
            label84.Text = num13.ToString();
            label85.Text = num20.ToString();

            label70.Text = num2.ToString();
            label75.Text = num6.ToString();
            label78.Text = num11.ToString();
            label83.Text = num14.ToString();
            label86.Text = num19.ToString();


            label71.Text = num3.ToString();
            label74.Text = num7.ToString();

            label72.Text = num4.ToString();
            label73.Text = num8.ToString();
        k:
            if (num10 == 1)
            {
                label82.Text = num15.ToString();
                label87.Text = num18.ToString();

            }
            else if (num10 != 1 && num10 != 0)
            {
                num15 = 1 / num10 * num15;
                num15 = Math.Round(num15, 2);
                label82.Text = num15.ToString();
                num18 = 1 / num10 * num18;
                num18 = Math.Round(num18, 2);
                label87.Text = num18.ToString();
                num10 = 1 / num10 * num10;
                num10 = Math.Round(num10, 2);
                label79.Text = num10.ToString();



            }
            else if (num10 == 0 && num9 != 0)
            {
                double xnum1 = num10;
                double xnum2 = num15;
                double xnum3 = num18;
                double xnum4 = num9;
                double xnum5 = num16;
                double xnum6 = num17;
                num10 = xnum4;
                num15 = xnum5;
                num18 = xnum6;
                num9 = xnum1;
                num16 = xnum2;
                num17 = xnum3;
                goto k;
            }

            if (num9 == 0)
            {
                label81.Text = num16.ToString();
                label88.Text = num17.ToString();
                label80.Text = num9.ToString();
            }
            else if (num9 == 1)
            {
                num16 = num16 - num15;
                num16 = Math.Round(num16, 2);
                label81.Text = num16.ToString();
                num17 = num17 - num18;
                num17 = Math.Round(num17, 2);
                label88.Text = num17.ToString();
                num9 = num9 - num10;
                num9 = Math.Round(num9, 2);
                label80.Text = num9.ToString();
            }
            else if (num9 == -1)
            {
                num16 = num16 + num15;
                num16 = Math.Round(num16, 2);
                label81.Text = num16.ToString();
                num17 = num17 + num18;
                num17 = Math.Round(num17, 2);
                label88.Text = num17.ToString();
                num9 = num9 + num10;
                num9 = Math.Round(num9, 2);
                label80.Text = num9.ToString();
            }
            else if (num9 != 0 && num9 != 1)
            {
                num16 = 1 / num9 * num16;
                num16 = Math.Round(num16, 2);
                num16 = num16 - num15;
                num16 = Math.Round(num16, 2);
                label81.Text = num16.ToString();
                num17 = 1 / num9 * num17;
                num17 = Math.Round(num17, 2);
                num17 = num17 - num18;
                num17 = Math.Round(num17, 2);
                label88.Text = num17.ToString();
                num9 = 1 / num9 * num9;
                num9 = Math.Round(num9, 2);
                num9 = num9 - num10;
                num9 = Math.Round(num9, 2);
                label80.Text = num9.ToString();
            }

            if (num16 != 0)
            {
                num17 = 1 / num16 * num17;
                num17 = Math.Round(num17, 2);
                num16 = 1 / num16 * num16;
                num16 = Math.Round(num16, 2);

                label68.Text = num17.ToString();
                label61.Text = num16.ToString();
                label49.Text = num1.ToString();
                label56.Text = num5.ToString();
                label57.Text = num12.ToString();
                label64.Text = num13.ToString();
                label65.Text = num20.ToString();


                label50.Text = num2.ToString();
                label55.Text = num6.ToString();
                label58.Text = num11.ToString();
                label63.Text = num14.ToString();
                label66.Text = num19.ToString();

                label51.Text = num3.ToString();
                label54.Text = num7.ToString();
                label59.Text = num10.ToString();
                label62.Text = num15.ToString();
                label67.Text = num18.ToString();

                label52.Text = num4.ToString();
                label53.Text = num8.ToString();
                label60.Text = num9.ToString();





            }
            else if (num16 == 0 && num17 != 0)
            {
                label155.Text = ("NO SOULUTION");

            }
            if (num16 != 0)
            {
                if (label69.Text == "0" && label76.Text == "0" && label77.Text == "0" && label84.Text == "0" && label85.Text == "0"&& label81.Text != "0" && label88.Text != "0" )
            {
                    label155.Text = "Infinty soulution.";
                }
                else if (label70.Text == "0" && label75.Text == "0" && label78.Text == "0" && label83.Text == "0" && label86.Text == "0"&& label81.Text != "0" && label88.Text != "0" )
            {
                    label155.Text = "Infinty soulution.";
                }else if (label71.Text == "0" && label74.Text == "0" && label79.Text == "0" && label82.Text == "0" && label87.Text == "0" &&label81.Text != "0" && label88.Text != "0" )
            {
                    label155.Text = "Infinty soulution.";
                }else

                {
                    label155.Text = "";
                    double x = double.Parse(label61.Text);
                    double y = double.Parse(label68.Text);

                    double z = y / x;
                    z = Math.Round(z, 1);
                    label92.Text = z.ToString();
                    double a = double.Parse(label59.Text);
                    double b = double.Parse(label62.Text);
                    double c = double.Parse(label67.Text);
                    double d = (c - (b * z)) / a;
                    d = Math.Round(d, 1);
                    label91.Text = d.ToString();

                    double n = double.Parse(label66.Text);
                    double m = double.Parse(label63.Text);
                    double o = double.Parse(label58.Text);
                    double p = double.Parse(label55.Text);
                    double v = (n - (o * d) - (m * z)) / p;
                    v = Math.Round(v, 1);
                    label90.Text = v.ToString();

                    double w = double.Parse(label65.Text);
                    double q = double.Parse(label56.Text);
                    double r = double.Parse(label57.Text);
                    double s = double.Parse(label64.Text);
                    double t = double.Parse(label49.Text);
                    double u = (w - (q * v) - (d * r) - (z * s)) / t;
                    u = Math.Round(u, 1);
                    label89.Text = u.ToString();
                }
            }
            else if (num16 == 0 && num15 == 0 && num17 == 0 && num14 != 0)
            {
                double x = double.Parse(label59.Text);
                double y = double.Parse(label67.Text);

                double z = y / x;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                label89.Text = "Infinity";
                label90.Text = "Infinity";
                label92.Text = "";
                label155.Text = "Infinty soulution..";

            }
            else if (num14 == 0 && num15 == 0 && num16 == 0 && num17 == 0 && num13 != 0)
            {
                double x = double.Parse(label59.Text);
                double y = double.Parse(label67.Text);

                double z = y / x;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                label92.Text = "";
                label89.Text = "Infinity";

                double a = double.Parse(label55.Text);
                double b = double.Parse(label58.Text);
                double c = double.Parse(label66.Text);
                double d = (c - (b * z)) / a;
                d = Math.Round(d, 1);
                label90.Text = d.ToString();
                label155.Text = "Infinty soulution..";

            }
            else if (num13 == 0 && num14 == 0 && num15 == 0 && num16 == 0 && num17 == 0)
            {
                double x = double.Parse(label59.Text);
                double y = double.Parse(label67.Text);

                double z = y / x;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                double a = double.Parse(label55.Text);
                double b = double.Parse(label58.Text);
                double c = double.Parse(label66.Text);
                double d = (c - (b * z)) / a;
                d = Math.Round(d, 1);
                label90.Text = d.ToString();
                label92.Text = "";


                double n = double.Parse(label65.Text);
                double m = double.Parse(label57.Text);
                double o = double.Parse(label56.Text);
                double p = double.Parse(label49.Text);
                double v = (n - (o * d) - (m * z)) / p;
                v = Math.Round(v, 1);
                label89.Text = v.ToString();

                label155.Text = "Infinty soulution..";
            }
            else if (num13 != 0 && num14 != 0 && num15 != 0 && num16 == 0 && num17 == 0)
            {
                label89.Text = "";
                label90.Text = "";
                label91.Text = "";
                label92.Text = "";
                label155.Text = "Infinty soulution..";
            }


        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
