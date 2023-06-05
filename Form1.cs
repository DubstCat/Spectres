using System;
using System.Windows.Forms;

namespace Spectres
{
    public partial class Form1 : Form
    {
        private MathCad mathCad;
        double[] M = new double[3];
        int N = 0;
        double m = 0;

        public Form1()
        {
            InitializeComponent();
            mathCad = new MathCad();
        }

        private void btnRazdel1_Click(object sender, EventArgs e)
        {
            if (!parametersAreCorrect()) return;
            var formRazdel1 = new FormRazdel1(mathCad, M, N);
            formRazdel1.Show();
        }

        private void btnRazdel2_Click(object sender, EventArgs e)
        {
            if (!parametersAreCorrect()) return;
            var formRazdel2 = new FormRazdel2(mathCad, new double[] { m }, N);
            formRazdel2.Show();
        }

        private bool parametersAreCorrect()
        {
            if (
                tb1M1.Text == tb1M2.Text || tb1M1.Text == tb1M3.Text || tb1M2.Text == tb1M3.Text
                || !double.TryParse(tb1M1.Text, out M[0]) || !double.TryParse(tb1M2.Text, out M[1]) || !double.TryParse(tb1M3.Text, out M[2]) || !double.TryParse(tb2M.Text, out m) || !int.TryParse(tb2N.Text, out N) ||
                    !double.TryParse(tbParamA.Text, out mathCad.A) || !double.TryParse(tbParamTau.Text, out mathCad.tau) || !double.TryParse(tbParamK.Text, out mathCad.K)
                )
            {
                MessageBox.Show("Проверьте введённые данные");
                return false;
            }
            return true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
