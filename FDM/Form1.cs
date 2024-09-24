using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FDM
{
    public partial class Form1 : Form
    {
        
        Timer timer = new Timer();
        double time=0, previosTemp,previosTemp1,MinTemp=350,Maxtemp=0;
        static int numpoints = 100;
        double[] data = new double[numpoints];
        static double L = 10, T = 300;
        static double stepX = L / numpoints;
        double stepT = 0.5 * stepX*stepX;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            textBox1.Text = ((Maxtemp - MinTemp) * 0.5).ToString();
        }

        private double Func(double t)
        {
            return 300 + 2 * Math.Sin(2 * Math.PI * 7 * t);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChartTX.ChartAreas[0].AxisY.Minimum = 297;
            ChartTX.ChartAreas[0].AxisY.Maximum = 303;
            ChartTt.ChartAreas[0].AxisY.Minimum = 299.95;
            ChartTt.ChartAreas[0].AxisY.Maximum = 300.05;
            for (int i = 0; i < numpoints; i++)
            {
                data[i] = T;
                ChartTX.Series[0].Points.AddXY(i*stepX, data[i]);
            }
            timer.Interval = 1;
            timer.Tick += (o, args) => timer_Tick(o,args);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            time += stepT;
            previosTemp = data[0];
            data[0] = Func(time);
            ChartTX.Series[0].Points.Clear();
            for(int i = 1; i < numpoints-1; i++)
            {
                previosTemp1 = data[i];
                data[i]=0.5*previosTemp + 0.5 * data[i + 1];
                ChartTX.Series[0].Points.AddXY(i*stepX, data[i]);
                previosTemp=previosTemp1;
            }
            if (time > 8.5)
            {
                ChartTt.Series[0].Points.AddXY(time, data[numpoints/5]);
            
                if (data[numpoints / 5] > Maxtemp)
                    Maxtemp = data[numpoints / 10];
                if (data[numpoints / 5] < MinTemp)
                    MinTemp = data[numpoints / 10];
            }
        }
        }
    }
