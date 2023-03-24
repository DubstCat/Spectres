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
    public partial class FormRazdel1 : Form
    {
        private int[] M;
        private MathCad mathCad;

        public FormRazdel1(MathCad mathCad, int [] M)
        {
            this.M = M;
            this.mathCad = mathCad;
            InitializeComponent();

            drawChart(this.chartU1, mathCad.razdel1U1, M);
            drawChart(this.chartE1, mathCad.razdel1E1, M);
            drawChart(this.chartO1, mathCad.razdel1O1, M);

        }

        private void drawChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, Func<int, List<FunctionPoint>> method, int[] M)
        {
            int index = 0;

            foreach(int currentM in M)
            {
                List<FunctionPoint> grafik = method.Invoke(currentM);

                foreach (FunctionPoint point in grafik)
                {
                    chart.Series[index].Points.AddXY(point.y, point.x);
                }
                index++;
            }
        }
    }
}
