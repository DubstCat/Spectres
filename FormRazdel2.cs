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
    public partial class FormRazdel2 : Form
    {

        private MathCad mathCad;
        public FormRazdel2(MathCad mathCad, int[] M)
        {
            this.mathCad = mathCad;
            InitializeComponent();
          

            ChartDrawer.drawChart(this.chartU2, mathCad.razdel2U2, M, 0);
            chartU2.Series[0].Name = "U2(t," + M[0] + ")";
            ChartDrawer.drawChart(this.chartE2, mathCad.razdel2E2, M, 0);
            chartE2.Series[0].Name = "E2(f," + M[0] + ")";
            ChartDrawer.drawChart(this.chartO2, mathCad.razdel2O2, M, 0);
            chartO2.Series[0].Name = "O2(f," + M[0] + ")";
        }
    }
}
