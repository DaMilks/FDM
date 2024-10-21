using System;
using System.Windows.Forms;

namespace FDM
{
    public partial class Form1 : Form
    {

        Timer timer = new Timer();
        double time = 0, previosTemp, previosTemp1, MinTemp, Maxtemp, MinTemp1, Maxtemp1;

        double time1 = 0, stepT1, s;
        double[] a = new double[numpoints], b = new double[numpoints];

        static int numpoints = 100;
        double[] data = new double[numpoints];
        double[] data1 = new double[numpoints];
        static double L = 10, T = 300, D = 2;
        static double stepX = L / numpoints;
        double stepT = 0.5 * stepX * stepX / 2;
        bool IsBreak = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            TextBoxAmplitude.Text = ((Maxtemp - MinTemp) * 0.5).ToString();
            TextBoxAmplitude1.Text = ((Maxtemp1 - MinTemp1) * 0.5).ToString();
        }

        private double Func(double t)
        {
            return 300 + 2 * Math.Sin(2 * Math.PI * 7 * t);
        }

        //Неявный метод сеток
        private void ImplictFiniteDifference()
        {
            time1 += stepT1;
            data1[0] = Func(time1);
            a[1] = 1 / (2 + s);
            b[1] = (data1[0] + s * data1[1]) / (2 + s);
            for (int i = 2; i < numpoints - 1; i++)
            {
                a[i] = 1 / (2 + s - a[i - 1]);
                b[i] = (b[i - 1] + s * data1[i]) / (2 + s - a[i - 1]);
            }
            for (int i = numpoints - 2; i >= 2; i--)
            {
                data1[i - 1] = a[i - 1] * data1[i] + b[i - 1];
            }
            time += stepT;
            previosTemp = data[0];
            data[0] = Func(time);

            for (int i = 1; i < numpoints - 1; i++)
            {
                previosTemp1 = data[i];


                data[i] = (1 / s) * previosTemp + (1 - 2 * (1 / s)) * data[i] + (1 / s) * data[i + 1];

                previosTemp = previosTemp1;
            }
            ChartTX1.Series[0].Points.Clear();
            ChartTX1.Series[1].Points.Clear();
            for (int i = 0; i < numpoints; i++)
            {
                ChartTX1.Series[1].Points.AddXY(i * stepX, data[i]);
                ChartTX1.Series[0].Points.AddXY(i * stepX, data1[i]);
            }

            if (time1 > 6)
            {
                ChartTt1.Series[0].Points.AddXY(time1, data1[numpoints / 10]);
                ChartTt1.Series[1].Points.AddXY(time1, data[numpoints / 10]);
                if (data1[numpoints / 10] > Maxtemp1)
                    Maxtemp1 = data1[numpoints / 10];
                if (data1[numpoints / 10] < MinTemp1)
                    MinTemp1 = data1[numpoints / 10];
                if (data[numpoints / 10] > Maxtemp)
                    Maxtemp = data[numpoints / 10];
                if (data[numpoints / 10] < MinTemp1)
                    MinTemp = data[numpoints / 10];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            time = 0;
            time1 = 0;

            MinTemp = 350;
            Maxtemp = 0;
            for (int i = 0; i < numpoints; i++)
            {
                data[i] = T;
            }


            MinTemp1 = 350;
            Maxtemp1 = 0;
            ChartTX1.Series[0].Points.Clear();
            ChartTX1.Series[1].Points.Clear();
            ChartTX1.ChartAreas[0].AxisY.Minimum = 297;
            ChartTX1.ChartAreas[0].AxisY.Maximum = 303;
            ChartTt1.Series[0].Points.Clear();
            ChartTt1.Series[1].Points.Clear();
            ChartTt1.ChartAreas[0].AxisY.Minimum = 299.9;
            ChartTt1.ChartAreas[0].AxisY.Maximum = 300.1;
            if (textBoxT.Text != "")
            {
                stepT1 = Convert.ToDouble(textBoxT.Text);
                stepT = stepT1;
            }

            else
            {
                stepT1 = stepT;
                textBoxT.Text = stepT1.ToString();
            }

            s = stepX * stepX / (stepT1 * D);
            textBoxS.Text = s.ToString();
            for (int i = 0; i < numpoints; i++)
            {
                data1[i] = T;
                ChartTX1.Series[0].Points.AddXY(i * stepX, data[i]);
            }


            timer.Interval = 1;
            timer.Tick += (o, args) => timer_Tick(o, args);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            ImplictFiniteDifference();

        }
    }
}
