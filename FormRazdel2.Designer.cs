
namespace Spectres
{
    partial class FormRazdel2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartU2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartU2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartU2
            // 
            chartArea1.Name = "ChartArea1";
            this.chartU2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartU2.Legends.Add(legend1);
            this.chartU2.Location = new System.Drawing.Point(12, 12);
            this.chartU2.Name = "chartU2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "U2(t, 6)";
            this.chartU2.Series.Add(series1);
            this.chartU2.Size = new System.Drawing.Size(776, 300);
            this.chartU2.TabIndex = 0;
            this.chartU2.Text = "chart1";
            // 
            // FormRazdel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartU2);
            this.Name = "FormRazdel2";
            this.Text = "FormRazdel2";
            ((System.ComponentModel.ISupportInitialize)(this.chartU2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartU2;
    }
}