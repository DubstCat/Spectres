
namespace Spectres
{
    partial class FormRazdel1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartU1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartE1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartO1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartO1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartU1
            // 
            this.chartU1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea1.Name = "ChartArea1";
            this.chartU1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartU1.Legends.Add(legend1);
            this.chartU1.Location = new System.Drawing.Point(12, 12);
            this.chartU1.Name = "chartU1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "U1(t, 0)";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.Name = "U1(t, 1)";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 10;
            series3.Name = "U1(t, 2)";
            this.chartU1.Series.Add(series1);
            this.chartU1.Series.Add(series2);
            this.chartU1.Series.Add(series3);
            this.chartU1.Size = new System.Drawing.Size(1709, 362);
            this.chartU1.TabIndex = 0;
            this.chartU1.Text = "chart1";
            // 
            // chartE1
            // 
            this.chartE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea2.Name = "ChartArea1";
            this.chartE1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartE1.Legends.Add(legend2);
            this.chartE1.Location = new System.Drawing.Point(12, 380);
            this.chartE1.Name = "chartE1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "E1(t, 1)";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "E1(t, 2)";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "E1(t, 0)";
            this.chartE1.Series.Add(series4);
            this.chartE1.Series.Add(series5);
            this.chartE1.Series.Add(series6);
            this.chartE1.Size = new System.Drawing.Size(1709, 362);
            this.chartE1.TabIndex = 1;
            this.chartE1.Text = "chart1";
            // 
            // chartO1
            // 
            this.chartO1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea3.Name = "ChartArea1";
            this.chartO1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartO1.Legends.Add(legend3);
            this.chartO1.Location = new System.Drawing.Point(12, 748);
            this.chartO1.Name = "chartO1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "O1(t, 0)";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "O1(t, 1)";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "O1(t, 2)";
            this.chartO1.Series.Add(series7);
            this.chartO1.Series.Add(series8);
            this.chartO1.Series.Add(series9);
            this.chartO1.Size = new System.Drawing.Size(1709, 362);
            this.chartO1.TabIndex = 2;
            this.chartO1.Text = "chart2";
            // 
            // FormRazdel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1754, 1055);
            this.Controls.Add(this.chartO1);
            this.Controls.Add(this.chartE1);
            this.Controls.Add(this.chartU1);
            this.Name = "FormRazdel1";
            this.Text = "FormRazdel1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRazdel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartO1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartU1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartO1;
    }
}