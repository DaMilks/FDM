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
        double time=0, temp;
        static int numpoints = 100;
        (double X, double Y)[] data = new (double, double)[numpoints];
        static double L = 10, T = 300;
        static double stepX = L / numpoints;
        double stepT = 0.5 * stepX*stepX;
        public Form1()
        {
            InitializeComponent();
        }
        private double Func(double t)
        {
            return 300 + 2 * Math.Sin(2 * Math.PI * 7 * t);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Chart.ChartAreas[0].AxisY.Minimum = 290;
            Chart.ChartAreas[0].AxisY.Maximum = 310;
            for (int i = 0; i < numpoints; i++)
            {

                data[i] = (i*stepX, T);
                Chart.Series[0].Points.AddXY(data[i].X, data[i].Y);
            }
            timer.Interval = 100;
            timer.Tick += (o, args) => timer_Tick(o,args);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            time += stepT;
            data[0] = (0, Func(time));
            Chart.Series[0].Points.Clear();
            for(int i = 1; i < numpoints-1; i++)
            {
                data[i]=(i*stepX,  0.5*data[i - 1].Y + 0.5 * data[i + 1].Y);
                Chart.Series[0].Points.AddXY(data[i].X, data[i].Y);
            }
                
        }
        }
    }
