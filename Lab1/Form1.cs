using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        decimal dt = 0.05M;
        decimal x1;
        int color=0;
        

        decimal x, y, v0, cosa, sina, S, m, k, vx, vy;

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[color].Points.AddXY(x, y);
            if (x1 < y)
            {
                x1 = y;
            }

            if (y <= 0)
            {
                timer1.Stop();
                labDistance.Text = Math.Round(x, 3).ToString();
                labTime.Text = dt.ToString();
                labHigh.Text = Math.Round(x1, 3).ToString();
                labSpeed.Text = Math.Round(v, 3).ToString();

            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            dt = dtInput.Value;
            color++;
            if (color == 7)
            {
                color = 0;
            }

            timer1.Stop();
            if (!timer1.Enabled)
            {
                x = 0;
                y = edHeight.Value;
                v0 = edSpeed.Value;
                double a = (double)edAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = edSize.Value;
                m = edMass.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[color].Points.AddXY(x, y);
                timer1.Start();
            }
            x1 = 0;
            
        }

        
    }
}
