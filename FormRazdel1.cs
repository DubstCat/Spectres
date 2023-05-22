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

        public FormRazdel1(MathCad mathCad, int [] M, int N)
        {
            this.M = M;
            this.mathCad = mathCad;
            InitializeComponent();
            drawCharts();
        }


        private void drawCharts()
        {
            chartU1.Series[0].Points.Clear();
            chartU1.Series[1].Points.Clear();
            chartU1.Series[2].Points.Clear();
            chartU1.Series[0].Name="";
            chartU1.Series[1].Name = "1";
            chartU1.Series[2].Name = "2";

            chartE1.Series[0].Points.Clear();
            chartE1.Series[1].Points.Clear();
            chartE1.Series[2].Points.Clear();
            chartE1.Series[0].Name = "";
            chartE1.Series[1].Name = "1";
            chartE1.Series[2].Name = "2";

            chartO1.Series[0].Points.Clear();
            chartO1.Series[1].Points.Clear();
            chartO1.Series[2].Points.Clear();
            chartO1.Series[0].Name = "";
            chartO1.Series[1].Name = "1";
            chartO1.Series[2].Name = "2";

            ChartDrawer.drawChart(this.chartU1, mathCad.razdel1U1, M, 0);
            addCaption(chartU1, "U1", "t", M);

            ChartDrawer.drawChart(this.chartE1, mathCad.razdel1E1, M, 0);
            addCaption(chartE1, "E1", "f", M);

            ChartDrawer.drawChart(this.chartO1, mathCad.razdel1O1, M, 0);
            addCaption(chartO1, "O1", "f", M);

        }
        private void increaseM()
        {
            M[0]+=3;
            M[1]+=3;
            M[2]+=3;
        }

        private void decreaseM()
        {
            M[0]-=3;
            M[1]-=3;
            M[2]-=3;
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

        // Checkboxes

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chartU1.Series[0].Enabled = checkBoxU1_1.Checked;
        }

        private void checkBoxU1_2_CheckedChanged(object sender, EventArgs e)
        {
            chartU1.Series[1].Enabled = checkBoxU1_2.Checked;
        }

        private void checkBoxU1_3_CheckedChanged(object sender, EventArgs e)
        {
            chartU1.Series[2].Enabled = checkBoxU1_3.Checked;
        }

        private void checkBoxE1_1_CheckedChanged(object sender, EventArgs e)
        {
            chartE1.Series[0].Enabled = checkBoxE1_1.Checked;
        }

        private void checkBoxE1_2_CheckedChanged(object sender, EventArgs e)
        {
            chartE1.Series[1].Enabled = checkBoxE1_2.Checked;
        }

        private void checkBoxE1_3_CheckedChanged(object sender, EventArgs e)
        {
            chartE1.Series[2].Enabled = checkBoxE1_3.Checked;
        }

        private void checkBoxO1_1_CheckedChanged(object sender, EventArgs e)
        {
            chartO1.Series[0].Enabled = checkBoxO1_1.Checked;
        }

        private void checkBoxO1_2_CheckedChanged(object sender, EventArgs e)
        {
            chartO1.Series[1].Enabled = checkBoxO1_2.Checked;
        }

        private void checkBoxO1_3_CheckedChanged(object sender, EventArgs e)
        {
            chartO1.Series[2].Enabled = checkBoxO1_3.Checked;
        }

        private void btnDecreaseM_Click(object sender, EventArgs e)
        {
            decreaseM();
            drawCharts();
        }

        private void btnIncreaseM_Click(object sender, EventArgs e)
        {
            increaseM();
            drawCharts();
        }
    }
}
