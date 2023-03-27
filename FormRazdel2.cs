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

        private int[] M;
        private MathCad mathCad;
        public FormRazdel2(MathCad mathCad, int[] M)
        {
            // this.M = M;
            this.mathCad = mathCad;
            InitializeComponent();
            int[] M6 = { 6 };
            int[] M0 = { 0 };

            ChartDrawer.drawChart(this.chartU2, mathCad.razdel2U2, M6);
            ChartDrawer.drawChart(this.chartE2, mathCad.razdel2E2, M6);
            ChartDrawer.drawChart(this.chartO2, mathCad.razdel2O2, M0);
        }
    }
}
