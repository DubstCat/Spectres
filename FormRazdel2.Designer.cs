
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartU2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartE2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartO2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartU2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartO2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartU2
            // 
            this.chartU2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea1.AxisX.MajorGrid.Interval = 2E-06D;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Maximum = 1E-05D;
            chartArea1.AxisX.Minimum = -1E-05D;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea1.Name = "ChartArea1";
            this.chartU2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartU2.Legends.Add(legend1);
            this.chartU2.Location = new System.Drawing.Point(12, 12);
            this.chartU2.Name = "chartU2";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "U2(t, 6)";
            this.chartU2.Series.Add(series1);
            this.chartU2.Size = new System.Drawing.Size(776, 300);
            this.chartU2.TabIndex = 0;
            this.chartU2.Text = "chart1";
            // 
            // chartE2
            // 
            this.chartE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea2.AxisX.MajorGrid.Interval = 800000D;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.Maximum = 4000000D;
            chartArea2.AxisX.Minimum = -4000000D;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea2.Name = "ChartArea1";
            this.chartE2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartE2.Legends.Add(legend2);
            this.chartE2.Location = new System.Drawing.Point(12, 318);
            this.chartE2.Name = "chartE2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "E2(f, 6)";
            this.chartE2.Series.Add(series2);
            this.chartE2.Size = new System.Drawing.Size(776, 300);
            this.chartE2.TabIndex = 1;
            this.chartE2.Text = "chart1";
            // 
            // chartO2
            // 
            this.chartO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea3.AxisX.MajorGrid.Interval = 800000D;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.Maximum = 4000000D;
            chartArea3.AxisX.Minimum = -4000000D;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea3.Name = "ChartArea1";
            this.chartO2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartO2.Legends.Add(legend3);
            this.chartO2.Location = new System.Drawing.Point(12, 633);
            this.chartO2.Name = "chartO2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "O2(f, 0)";
            this.chartO2.Series.Add(series3);
            this.chartO2.Size = new System.Drawing.Size(776, 300);
            this.chartO2.TabIndex = 2;
            this.chartO2.Text = "chart1";
            // 
            // FormRazdel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1293, 820);
            this.Controls.Add(this.chartO2);
            this.Controls.Add(this.chartE2);
            this.Controls.Add(this.chartU2);
            this.Name = "FormRazdel2";
            this.Text = "FormRazdel2";
            ((System.ComponentModel.ISupportInitialize)(this.chartU2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartO2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartU2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartO2;
    }
}