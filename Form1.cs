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
    public partial class Form1 : Form
    {
        private MathCad mathCad;
        int[] M = new int[3];

        public Form1()
        {
            InitializeComponent();
            mathCad = new MathCad();
        }

        private void btnRazdel1_Click(object sender, EventArgs e)
        {
            if (!parameterMisCorrect()) return;
           //M = { int.Parse(tb1M1.Text), int.Parse(tb1M2.Text), int.Parse(tb1M3.Text)};
            var formRazdel1 = new FormRazdel1(mathCad, M);
            formRazdel1.Activate();
            formRazdel1.Show();
        }

        private void btnRazdel2_Click(object sender, EventArgs e)
        {
            var formRazdel2 = new FormRazdel2(mathCad, new int[0]);
            formRazdel2.Activate();
            formRazdel2.Show();
        }

        private bool parameterMisCorrect()
        {
            if (
                tb1M1.Text == tb1M2.Text || tb1M1.Text == tb1M3.Text || tb1M2.Text == tb1M3.Text
                || !int.TryParse(tb1M1.Text, out M[0]) || !int.TryParse(tb1M2.Text, out M[1]) || !int.TryParse(tb1M3.Text, out M[2])
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
    }
}
