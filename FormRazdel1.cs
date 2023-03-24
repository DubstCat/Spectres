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

            ChartDrawer.drawChart(this.chartU1, mathCad.razdel1U1, M);
            ChartDrawer.drawChart(this.chartE1, mathCad.razdel1E1, M);
            ChartDrawer.drawChart(this.chartO1, mathCad.razdel1O1, M);

        }

        private void FormRazdel1_Load(object sender, EventArgs e)
        {

        }
    }
}
