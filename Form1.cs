namespace gabr
{
     //yes or no
    //kareem
    //code
    public partial class Form1 : Form
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
        public double num21;
        public double num22;
        public double num23;
        public double num24;
        public double num25;




        public Form1(double num1,

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
            double num20,
             double num21,
              double num22,
               double num23,
                double num24,
            double num25
            )
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
            this.num21 = num21;
            this.num22 = num22;
            this.num23 = num23;
            this.num24 = num24;
            this.num25 = num25;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
                num6 = Math.Round(num6, 2);
                num11 = 1 / num2 * num11;
                num11 = Math.Round(num11, 2);
                num11 = num11 - num12;
                num11 = Math.Round(num11, 2);

                num14 = 1 / num2 * num14;
                num14 = Math.Round(num14, 2);
                num14 = num14 - num13;
                num14 = Math.Round(num14, 2);

                num19 = 1 / num2 * num19;
                num19 = Math.Round(num19, 2);
                num19 = num19 - num20;
                num19 = Math.Round(num19, 2);
                num2 = 1 / num2 * num2;
                num2 = Math.Round(num2, 2);
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

            }


            else if (num4 == 0)
            {

                label8.Text = num4.ToString();
                label15.Text = num8.ToString();
                label16.Text = num9.ToString();
                label23.Text = num16.ToString();
                label27.Text = num17.ToString();


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

            }

            if (num21 == 1)
            {
                num22 = num22 - num5;
                num22 = Math.Round(num22, 2);
                num23 = num23 - num12;
                num23 = Math.Round(num23, 2);
                num24 = num24 - num13;
                num24 = Math.Round(num24, 2);
                num25 = num25 - num20;
                num25 = Math.Round(num25, 2);
                num21 = num21 - num1;
                num21 = Math.Round(num21, 2);
                label110.Text = num4.ToString();
                label111.Text = num8.ToString();
                label112.Text = num9.ToString();
                label113.Text = num16.ToString();
                label114.Text = num17.ToString();

            }

            else if (num21 == -1)
            {
                num22 = num22 + num5;
                num22 = Math.Round(num22, 2);
                num23 = num23 + num12;
                num23 = Math.Round(num23, 2);
                num24 = num24 + num13;
                num24 = Math.Round(num24, 2);
                num25 = num25 + num20;
                num25 = Math.Round(num25, 2);
                num21 = num21 + num1;
                num21 = Math.Round(num21, 2);
                label110.Text = num4.ToString();
                label111.Text = num8.ToString();
                label112.Text = num9.ToString();
                label113.Text = num16.ToString();
                label114.Text = num17.ToString();

            }


            else if (num21 == 0)
            {

                label110.Text = num4.ToString();
                label111.Text = num8.ToString();
                label112.Text = num9.ToString();
                label113.Text = num16.ToString();
                label114.Text = num17.ToString();



            }
            else if (num21 != 0 && num21 != 1)
            {

                num22 = 1 / num21 * num22;
                num22 = Math.Round(num22, 2);
                num22 = num22 - num5;
                num22 = Math.Round(num22, 2);


                num23 = 1 / num21 * num23;
                num23 = Math.Round(num23, 2);
                num23 = num23 - num12;
                num23 = Math.Round(num23, 2);

                num24 = 1 / num21 * num24;
                num24 = Math.Round(num24, 2);
                num24 = num24 - num13;
                num24 = Math.Round(num24, 2);


                num25 = 1 / num21 * num25;
                num25 = Math.Round(num25, 2);
                num25 = num17 - num20;
                num25 = Math.Round(num25, 2);


                num21 = 1 / num21 * num21;
                num21 = Math.Round(num21, 2);
                num21 = num21 - num1;
                num21 = Math.Round(num21, 2);

                label110.Text = num4.ToString();
                label111.Text = num8.ToString();
                label112.Text = num9.ToString();
                label113.Text = num16.ToString();
                label114.Text = num17.ToString();
            }



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

            }


            else if (num8 == 0)
            {
                label30.Text = num4.ToString();
                label31.Text = num8.ToString();
                label38.Text = num9.ToString();
                label39.Text = num16.ToString();
                label46.Text = num17.ToString();


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


            }


            if (num22 == 1)
            {
                num23 = num23 - num11;
                num23 = Math.Round(num23, 2);
                num24 = num24 - num14;
                num24 = Math.Round(num24, 2);
                num25 = num25 - num19;
                num25 = Math.Round(num25, 2);
                num22 = num22 - num6;
                num22 = Math.Round(num22, 2);
                label115.Text = num21.ToString();
                label116.Text = num22.ToString();
                label117.Text = num23.ToString();
                label118.Text = num24.ToString();
                label119.Text = num25.ToString();

            }
            else if (num22 == -1)
            {
                num23 = num23 + num11;
                num23 = Math.Round(num23, 2);
                num24 = num24 + num14;
                num24 = Math.Round(num24, 2);
                num25 = num25 + num19;
                num25 = Math.Round(num25, 2);
                num22 = num22 + num6;
                num22 = Math.Round(num22, 2);
                label115.Text = num21.ToString();
                label116.Text = num22.ToString();
                label117.Text = num23.ToString();
                label118.Text = num24.ToString();
                label119.Text = num25.ToString();

            }


            else if (num22 == 0)
            {
                label115.Text = num21.ToString();
                label116.Text = num22.ToString();
                label117.Text = num23.ToString();
                label118.Text = num24.ToString();
                label119.Text = num25.ToString();


            }
            else if (num22 != 0 && num22 != 1)
            {


                num23 = 1 / num22 * num23;
                num23 = Math.Round(num23, 2);
                num23 = num23 - num11;
                num23 = Math.Round(num23, 2);


                num16 = 1 / num22 * num16;
                num16 = Math.Round(num16, 2);
                num16 = num16 - num14;
                num16 = Math.Round(num16, 2);


                num17 = 1 / num22 * num17;
                num17 = Math.Round(num17, 2);
                num17 = num17 - num19;
                num17 = Math.Round(num17, 2);


                num22 = 1 / num22 * num22;
                num22 = Math.Round(num22, 2);
                num22 = num22 - num6;
                num22 = Math.Round(num22, 2);


                label115.Text = num21.ToString();
                label116.Text = num22.ToString();
                label117.Text = num23.ToString();
                label118.Text = num24.ToString();
                label119.Text = num25.ToString();

            }


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
            label120.Text = num21.ToString();
            label121.Text = num22.ToString();

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

            if (num23 == 0)
            {
                label123.Text = num24.ToString();
                label124.Text = num25.ToString();
                label122.Text = num23.ToString();
            }
            else if (num23 == 1)
            {
                num24 = num24 - num15;
                num24 = Math.Round(num24, 2);
                label123.Text = num24.ToString();
                num25 = num25 - num18;
                num25 = Math.Round(num25, 2);
                label124.Text = num25.ToString();
                num23 = num23 - num10;
                num23 = Math.Round(num23, 2);
                label122.Text = num23.ToString();
            }
            else if (num23 == -1)
            {
                num24 = num24 - num15;
                num24 = Math.Round(num24, 2);
                label123.Text = num24.ToString();
                num25 = num25 - num18;
                num25 = Math.Round(num25, 2);
                label124.Text = num25.ToString();
                num23 = num23 - num10;
                num23 = Math.Round(num23, 2);
                label122.Text = num23.ToString();
            }
            else if (num23 != 0 && num23 != 1)
            {
                num24 = 1 / num23 * num24;
                num24 = Math.Round(num16, 2);
                num24 = num16 - num15;
                num24 = Math.Round(num16, 2);
                label123.Text = num16.ToString();


                num25 = 1 / num23 * num25;
                num25 = Math.Round(num25, 2);
                num25 = num17 - num18;
                num25 = Math.Round(num25, 2);
                label124.Text = num25.ToString();


                num23 = 1 / num23 * num23;
                num23 = Math.Round(num23, 2);
                num23 = num23 - num10;
                num23 = Math.Round(num23, 2);
                label122.Text = num23.ToString();
            }




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


            label125.Text = num21.ToString();
            label126.Text = num22.ToString();
            label127.Text = num23.ToString();





        m:
            if (num16 == 1)
            {
                label68.Text = num17.ToString();
                label61.Text = num16.ToString();

            }
            else if (num16 != 1 && num16 != 0)
            {


                num17 = 1 / num16 * num17;
                num17 = Math.Round(num17, 2);
                label68.Text = num17.ToString();

                num16 = 1 / num16 * num16;
                num16 = Math.Round(num16, 2);
                label61.Text = num16.ToString();



            }
            else if (num16 == 0 && num24 != 0)
            {
                double tnum1 = num16;
                double tnum2 = num17;
                double tnum3 = num24;
                double tnum4 = num25;


                num16 = tnum3;
                num17 = tnum4;
                num24 = tnum1;


                num25 = tnum2;
                goto m;
            } else if (num16 == 0 && num24 == 0)
            {
                goto h;
            }
        h: if (num24 == 0)
            {
                label129.Text = num25.ToString();
                label128.Text = num24.ToString();
                label127.Text = num23.ToString();
                label126.Text = num22.ToString();
                label125.Text = num21.ToString();

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
                label68.Text = num17.ToString();
                label61.Text = num16.ToString();


            }
            else if (num24 != 0 && num24 != 1 && num24 != -1)
            {
                num25 = 1 / num24 * num25;
                num25 = Math.Round(num25, 2);
                num25 = num25 - num17;
                num25 = Math.Round(num25, 2);
                label129.Text = num25.ToString();

                num24 = 1 / num24 * num24;
                num24 = Math.Round(num24, 2);
                num24 = num24 - num16;
                num24 = Math.Round(num24, 2);
                label128.Text = num24.ToString();

            }
            else if (num24 == 1)
            {
                num25 = num25 - num17;
                num25 = Math.Round(num25, 2);
                label129.Text = num25.ToString();
                num24 = num24 - num16;
                num24 = Math.Round(num24, 2);
                label128.Text = num24.ToString();
            }
            else if (num24 == -1)
            {
                num25 = num25 + num17;
                num25 = Math.Round(num25, 2);
                label129.Text = num25.ToString();
                num24 = num24 + num16;
                num24 = Math.Round(num24, 2);
                label128.Text = num24.ToString();
            }
            if (num25 != 0)
            {
                label130.Text = num25.ToString();
                label131.Text = num24.ToString();
                label132.Text = num23.ToString();
                label133.Text = num22.ToString();
                label134.Text = num21.ToString();

                label137.Text = num1.ToString();
                label144.Text = num5.ToString();
                label145.Text = num12.ToString();
                label152.Text = num13.ToString();
                label153.Text = num20.ToString();

                label138.Text = num2.ToString();
                label143.Text = num6.ToString();
                label146.Text = num11.ToString();
                label151.Text = num14.ToString();
                label154.Text = num19.ToString();

                label139.Text = num3.ToString();
                label142.Text = num7.ToString();
                label147.Text = num10.ToString();
                label150.Text = num15.ToString();
                label155.Text = num18.ToString();

                label140.Text = num4.ToString();
                label141.Text = num8.ToString();
                label148.Text = num9.ToString();
                label149.Text = num16.ToString();
                label156.Text = num17.ToString();


                label89.Text = "";
                label90.Text = "";
                label91.Text = "";
                label92.Text = "";

                label160.Text = "No SOULUTION..";


            } else if (num25 == 0 && num16 != 0)
            {


                double x = double.Parse(label156.Text);
                double y = double.Parse(label149.Text);
                double z = x / y;
                z = Math.Round(z, 1);
                label92.Text = z.ToString();

                double q = double.Parse(label155.Text);
                double r = double.Parse(label150.Text);
                double s = double.Parse(label147.Text);
                double t = (q - (r * z)) / s;
                t = Math.Round(t, 1);
                label91.Text = t.ToString();

                double a = double.Parse(label154.Text);
                double b = double.Parse(label151.Text);
                double c = double.Parse(label146.Text);
                double x1 = double.Parse(label143.Text);
                double d = (a - (z * b) - (t * c)) / x1;
                d = Math.Round(d, 1);
                label90.Text = d.ToString();

                double w = double.Parse(label135.Text);
                double h = double.Parse(label144.Text);
                double n = double.Parse(label145.Text);
                double m = double.Parse(label152.Text);
                double l = double.Parse(label137.Text);
                double x2 = (w - (h * d) - (t * n) - (z * m)) / l;
                x2 = Math.Round(x2, 1);
                label89.Text = x2.ToString();
            } else if (num25 == 0 && num16 == 0 && num15 == 0 && num14 == 0 && num13 == 0)
            {
                double x = double.Parse(label155.Text);
                double y = double.Parse(label147.Text);
                double z = x / y;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                label92.Text = "";
                label160.Text = "infinity soulution..";
                double q = double.Parse(label154.Text);
                double r = double.Parse(label146.Text);
                double s = double.Parse(label143.Text);
                double t = (q - (r * z)) / s;
                t = Math.Round(t, 1);
                label90.Text = t.ToString();


                double a = double.Parse(label153.Text);
                double b = double.Parse(label145.Text);
                double c = double.Parse(label144.Text);
                double x1 = double.Parse(label137.Text);
                double d = (a - (z * b) - (t * c)) / x1;
                d = Math.Round(d, 1);
                label89.Text = d.ToString();

            }
            else if (num25 == 0 && num16 == 0 && num15 == 0 && num14 != 0)
            {
                double x = double.Parse(label155.Text);
                double y = double.Parse(label147.Text);
                double z = x / y;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                label92.Text = "";
                label89.Text = "Infinity";
                label90.Text = "Infinity";
                label160.Text = "The soulution is infinity.";
            }
            else if (num25 == 0 && num16 == 0 && num15 == 0 && num14 == 0&&num13!=0)
            {
                double x = double.Parse(label155.Text);
                double y = double.Parse(label147.Text);
                double z = x / y;
                z = Math.Round(z, 1);
                label91.Text = z.ToString();
                label92.Text = "";
                label89.Text = "Infinity";
                double q = double.Parse(label154.Text);
                double r = double.Parse(label146.Text);
                double s = double.Parse(label143.Text);
                double t = (q - (r * z)) / s;
                t = Math.Round(t, 1);
                label90.Text = t.ToString();
                label160.Text = "The soulution is infinity.";
            }
            else if (num25 == 0 && num16 == 0 && num15 != 0 && num14 != 0 && num13 != 0)
            {
                label91.Text = "";
                label92.Text = "";
                label89.Text = "";
                     label90.Text = "";
                label160.Text = "The soulution is infinity.";
            }








        }

            private void groupBox7_Enter(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void print_Click(object sender, EventArgs e)
            {



            
            }
        }
    }
