using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectres
{
    public partial class Form1 : Form
    {
        private MathCad mathCad;
        int[] M = {0, 1, 2};

        public Form1()
        {
            InitializeComponent();
            mathCad = new MathCad();
        }

        private void btnRazdel1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Update();
            int index = 0;
            foreach(int currentM in M)
            {
                List<FunctionPoint> grafik = mathCad.razdel1U1(currentM);

                foreach (FunctionPoint point in grafik)
                {
                    this.chart1.Series[index].Points.AddXY(point.y, point.x);
                }
                index++;
            }
        }

        private void btnRazdel2_Click(object sender, EventArgs e)
        {
            this.chart2.Series[0].Points.Clear();
            this.chart2.Update();
            
            int index = 0;
            foreach (int currentM in M)
            {
                List<FunctionPoint> grafik = mathCad.razdel1E1(currentM);

                foreach (FunctionPoint point in grafik)
                {
                    this.chart2.Series[index].Points.AddXY(point.y, point.x);
                }
                index++;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var formRazdel1 = new FormRazdel1(mathCad, M);
            formRazdel1.Activate();
            formRazdel1.Show();
            
            List<FunctionPoint> grafik = mathCad.razdel2U2(6);

            foreach(FunctionPoint point in grafik)
            {
                this.chart2.Series[0].Points.AddXY(point.y, point.x);
            }
        }
    }
}
