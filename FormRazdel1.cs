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

            int index = 0;
            foreach (int currentM in M)
            {
                List<FunctionPoint> grafik = mathCad.razdel1E1(currentM);

                foreach (FunctionPoint point in grafik)
                {
                    this.chartU1.Series[index].Points.AddXY(point.y, point.x);
                }
                index++;
            }

        }
    }
}
