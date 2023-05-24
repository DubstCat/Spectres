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
            ChartDrawer.drawChart(this.chartU2, mathCad.razdel2U2, M, N);
            chartU2.Series[0].Name = "U2(t," + M[0] + ")";

            chartE2.ChartAreas[0].AxisY.Maximum = mathCad.E2(0, M[0], N);
            ChartDrawer.drawChart(this.chartE2, mathCad.razdel2E2, M, N);
            chartE2.Series[0].Name = "E2(f," + M[0] + ")";


            ChartDrawer.drawChart(this.chartO2, mathCad.razdel2O2, M, N);
            chartO2.Series[0].Name = "O2(f," + M[0] + ")";
        }
    }
}
