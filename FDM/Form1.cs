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
        double time=0, previosTemp,previosTemp1,MinTemp=350,Maxtemp=0,dk;
        static int numpoints = 30;
        double[] data = new double[numpoints];
        static double L = 10, T = 0,Diffkoef1=3,Diffkoef2=1;
        static double stepX = L / numpoints;
        double stepT = stepX*stepX/(2*Diffkoef1*Diffkoef2);
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
        private double D(int n)
        {
            if(numpoints/3.0<n&n<numpoints*2.0/3)
                    return Diffkoef2;
                else
                    return Diffkoef1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            data[0] = 100;
                
            ChartTX.Series[0].Points.AddXY(0, data[0]);
            for (int i = 1; i < numpoints; i++)
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
            data[0] = 100;
            ChartTX.Series[0].Points.Clear();
            for(int i = 1; i < numpoints-1; i++)
            {
                
                previosTemp1 = data[i];
                data[i]=data[i]-stepT/(stepX*stepX)*(D(i+1)*(data[i]-data[i+1])+D(i-1)*(data[i]-previosTemp));
                ChartTX.Series[0].Points.AddXY(i*stepX, data[i]);
                previosTemp=previosTemp1;
            }
        }
        }
    }
