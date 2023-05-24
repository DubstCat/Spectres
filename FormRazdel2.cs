using System.Windows.Forms;

namespace Spectres
{
    public partial class FormRazdel2 : Form
    {

        private MathCad mathCad;
        public FormRazdel2(MathCad mathCad, double[] M, int N)
        {
            this.mathCad = mathCad;
            InitializeComponent();

            chartU2.ChartAreas[0].AxisX.Minimum = -mathCad.tau * 5 * (N+1);
            chartU2.ChartAreas[0].AxisX.Maximum = mathCad.tau * 5 * (N+1);
            chartU2.ChartAreas[0].AxisX.Interval = (mathCad.tau * 5 * (N + 1)) / 5;
            chartU2.ChartAreas[0].AxisX.MajorGrid.Interval = (mathCad.tau * 5 * (N + 1)) / 5;
            ChartDrawer.drawChart(this.chartU2, mathCad.razdel2U2, M, N);
            chartU2.Series[0].Name = "U2(t," + M[0] + ")";

            chartE2.ChartAreas[0].AxisX.Minimum =  -8 / mathCad.tau;
            chartE2.ChartAreas[0].AxisX.Maximum =  8 / mathCad.tau;
            chartE2.ChartAreas[0].AxisX.Interval = 8 / mathCad.tau / 5;
            chartE2.ChartAreas[0].AxisX.MajorGrid.Interval = 8 / mathCad.tau / 5;
            chartE2.ChartAreas[0].AxisY.Maximum = mathCad.E2(0, M[0], N);
            ChartDrawer.drawChart(this.chartE2, mathCad.razdel2E2, M, N);
            chartE2.Series[0].Name = "E2(f," + M[0] + ")";

            chartO2.ChartAreas[0].AxisX.Minimum =  -8 / mathCad.tau;
            chartO2.ChartAreas[0].AxisX.Maximum =  8 / mathCad.tau;
            chartO2.ChartAreas[0].AxisX.Interval = 8 / mathCad.tau / 5;
            chartO2.ChartAreas[0].AxisX.MajorGrid.Interval = 8 / mathCad.tau / 5;
            ChartDrawer.drawChart(this.chartO2, mathCad.razdel2O2, M, N);
            chartO2.Series[0].Name = "O2(f," + M[0] + ")";
        }
    }
}
