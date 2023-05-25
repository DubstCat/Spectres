using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Spectres
{
    public partial class FormRazdel1 : Form
    {
        private double[] M;
        private MathCad mathCad;

        public FormRazdel1(MathCad mathCad, double [] M, int N)
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


            chartU1.ChartAreas[0].AxisX.Interval = mathCad.tau / 5;
            chartU1.ChartAreas[0].AxisX.MajorGrid.Interval = mathCad.tau / 5;
            chartE1.ChartAreas[0].AxisX.Minimum = -mathCad.tau;
            chartE1.ChartAreas[0].AxisX.Maximum = mathCad.tau;
            ChartDrawer.drawChart(this.chartU1, mathCad.razdel1U1, M, 0);
            addCaption(chartU1, "U1", "t", M);

            chartE1.ChartAreas[0].AxisX.Minimum = -4000000;
            chartE1.ChartAreas[0].AxisX.Maximum = 4000000;
            chartE1.ChartAreas[0].AxisX.Interval = 4000000 / 5;
            chartE1.ChartAreas[0].AxisX.MajorGrid.Interval = 4000000 / 5;
            ChartDrawer.drawChart(this.chartE1, mathCad.razdel1E1, M, 0);
            addCaption(chartE1, "E1", "f", M);

            chartO1.ChartAreas[0].AxisX.Minimum = -4000000;
            chartO1.ChartAreas[0].AxisX.Maximum = 4000000;
            chartO1.ChartAreas[0].AxisX.Interval = 4000000 / 5;
            chartO1.ChartAreas[0].AxisX.MajorGrid.Interval = 4000000 / 5;
            ChartDrawer.drawChart(this.chartO1, mathCad.razdel1O1, M, 0);
            addCaption(chartO1, "O1", "f", M);

        }
        private void increaseM()
        {
            M[0]+=1.5;
            M[1]+=1.5;
            M[2]+=1.5;
        }

        private void decreaseM()
        {
            M[0]-=1.5;
            M[1]-=1.5;
            M[2]-=1.5;
        }

        private void addCaption(Chart chart, string name, string parameter, double [] M)
        {
            int i = 0;
            foreach(double m in M)
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
