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

            ChartDrawer.drawChart(this.chartU1, mathCad.razdel1U1, M);
            addCaption(chartU1, "U1", "t", M);

            ChartDrawer.drawChart(this.chartE1, mathCad.razdel1E1, M);
            addCaption(chartE1, "E1", "f", M);

            ChartDrawer.drawChart(this.chartO1, mathCad.razdel1O1, M);
            addCaption(chartO1, "O1", "f", M);

        }

        private void addCaption(Chart chart, string name, string parameter, int [] M)
        {
            int i = 0;
            foreach(int m in M)
            {
                chart.Series[i].Name = name + "(" + parameter + "," + m + ")";
                i++;
            }
        }

        private void FormRazdel1_Load(object sender, EventArgs e)
        {

        }
    }
}
