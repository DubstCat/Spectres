
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartU1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartE1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartO1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxU1_1 = new System.Windows.Forms.CheckBox();
            this.checkBoxU1_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxU1_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxE1_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxE1_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxE1_1 = new System.Windows.Forms.CheckBox();
            this.checkBoxO1_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxO1_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxO1_1 = new System.Windows.Forms.CheckBox();
            this.btnIncreaseM = new System.Windows.Forms.Button();
            this.btnDecreaseM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartO1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartU1
            // 
            this.chartU1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea4.AxisX.MajorGrid.Interval = 2E-07D;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea4.Name = "ChartArea1";
            this.chartU1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartU1.Legends.Add(legend4);
            this.chartU1.Location = new System.Drawing.Point(1, 12);
            this.chartU1.Name = "chartU1";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.MarkerSize = 10;
            series10.Name = "U1(t, 0)";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.MarkerSize = 10;
            series11.Name = "U1(t, 1)";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.MarkerSize = 10;
            series12.Name = "U1(t, 2)";
            this.chartU1.Series.Add(series10);
            this.chartU1.Series.Add(series11);
            this.chartU1.Series.Add(series12);
            this.chartU1.Size = new System.Drawing.Size(1709, 362);
            this.chartU1.TabIndex = 0;
            this.chartU1.Text = "chart1";
            // 
            // chartE1
            // 
            this.chartE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea5.AxisX.MajorGrid.Interval = 400000D;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea5.Name = "ChartArea1";
            this.chartE1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartE1.Legends.Add(legend5);
            this.chartE1.Location = new System.Drawing.Point(12, 380);
            this.chartE1.Name = "chartE1";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "E1(f, 0)";
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "E1(f, 1)";
            series15.BorderWidth = 3;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "E1(f, 2)";
            this.chartE1.Series.Add(series13);
            this.chartE1.Series.Add(series14);
            this.chartE1.Series.Add(series15);
            this.chartE1.Size = new System.Drawing.Size(1709, 362);
            this.chartE1.TabIndex = 1;
            this.chartE1.Text = "chart1";
            // 
            // chartO1
            // 
            this.chartO1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea6.AxisX.MajorGrid.Interval = 400000D;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            chartArea6.Name = "ChartArea1";
            this.chartO1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartO1.Legends.Add(legend6);
            this.chartO1.Location = new System.Drawing.Point(12, 748);
            this.chartO1.Name = "chartO1";
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "O1(f, 0)";
            series17.BorderWidth = 3;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "O1(f, 1)";
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "O1(f, 2)";
            this.chartO1.Series.Add(series16);
            this.chartO1.Series.Add(series17);
            this.chartO1.Series.Add(series18);
            this.chartO1.Size = new System.Drawing.Size(1709, 362);
            this.chartO1.TabIndex = 2;
            this.chartO1.Text = "chart2";
            // 
            // checkBoxU1_1
            // 
            this.checkBoxU1_1.AutoSize = true;
            this.checkBoxU1_1.Checked = true;
            this.checkBoxU1_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxU1_1.Location = new System.Drawing.Point(1675, 24);
            this.checkBoxU1_1.Name = "checkBoxU1_1";
            this.checkBoxU1_1.Size = new System.Drawing.Size(18, 17);
            this.checkBoxU1_1.TabIndex = 3;
            this.checkBoxU1_1.UseVisualStyleBackColor = true;
            this.checkBoxU1_1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxU1_2
            // 
            this.checkBoxU1_2.AutoSize = true;
            this.checkBoxU1_2.Checked = true;
            this.checkBoxU1_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxU1_2.Location = new System.Drawing.Point(1675, 47);
            this.checkBoxU1_2.Name = "checkBoxU1_2";
            this.checkBoxU1_2.Size = new System.Drawing.Size(18, 17);
            this.checkBoxU1_2.TabIndex = 4;
            this.checkBoxU1_2.UseVisualStyleBackColor = true;
            this.checkBoxU1_2.CheckedChanged += new System.EventHandler(this.checkBoxU1_2_CheckedChanged);
            // 
            // checkBoxU1_3
            // 
            this.checkBoxU1_3.AutoSize = true;
            this.checkBoxU1_3.Checked = true;
            this.checkBoxU1_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxU1_3.Location = new System.Drawing.Point(1675, 70);
            this.checkBoxU1_3.Name = "checkBoxU1_3";
            this.checkBoxU1_3.Size = new System.Drawing.Size(18, 17);
            this.checkBoxU1_3.TabIndex = 5;
            this.checkBoxU1_3.UseVisualStyleBackColor = true;
            this.checkBoxU1_3.CheckedChanged += new System.EventHandler(this.checkBoxU1_3_CheckedChanged);
            // 
            // checkBoxE1_3
            // 
            this.checkBoxE1_3.AutoSize = true;
            this.checkBoxE1_3.Checked = true;
            this.checkBoxE1_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxE1_3.Location = new System.Drawing.Point(1675, 438);
            this.checkBoxE1_3.Name = "checkBoxE1_3";
            this.checkBoxE1_3.Size = new System.Drawing.Size(18, 17);
            this.checkBoxE1_3.TabIndex = 8;
            this.checkBoxE1_3.UseVisualStyleBackColor = true;
            this.checkBoxE1_3.CheckedChanged += new System.EventHandler(this.checkBoxE1_3_CheckedChanged);
            // 
            // checkBoxE1_2
            // 
            this.checkBoxE1_2.AutoSize = true;
            this.checkBoxE1_2.Checked = true;
            this.checkBoxE1_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxE1_2.Location = new System.Drawing.Point(1675, 415);
            this.checkBoxE1_2.Name = "checkBoxE1_2";
            this.checkBoxE1_2.Size = new System.Drawing.Size(18, 17);
            this.checkBoxE1_2.TabIndex = 7;
            this.checkBoxE1_2.UseVisualStyleBackColor = true;
            this.checkBoxE1_2.CheckedChanged += new System.EventHandler(this.checkBoxE1_2_CheckedChanged);
            // 
            // checkBoxE1_1
            // 
            this.checkBoxE1_1.AutoSize = true;
            this.checkBoxE1_1.Checked = true;
            this.checkBoxE1_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxE1_1.Location = new System.Drawing.Point(1675, 392);
            this.checkBoxE1_1.Name = "checkBoxE1_1";
            this.checkBoxE1_1.Size = new System.Drawing.Size(18, 17);
            this.checkBoxE1_1.TabIndex = 6;
            this.checkBoxE1_1.UseVisualStyleBackColor = true;
            this.checkBoxE1_1.CheckedChanged += new System.EventHandler(this.checkBoxE1_1_CheckedChanged);
            // 
            // checkBoxO1_3
            // 
            this.checkBoxO1_3.AutoSize = true;
            this.checkBoxO1_3.Checked = true;
            this.checkBoxO1_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxO1_3.Location = new System.Drawing.Point(1675, 806);
            this.checkBoxO1_3.Name = "checkBoxO1_3";
            this.checkBoxO1_3.Size = new System.Drawing.Size(18, 17);
            this.checkBoxO1_3.TabIndex = 11;
            this.checkBoxO1_3.UseVisualStyleBackColor = true;
            this.checkBoxO1_3.CheckedChanged += new System.EventHandler(this.checkBoxO1_3_CheckedChanged);
            // 
            // checkBoxO1_2
            // 
            this.checkBoxO1_2.AutoSize = true;
            this.checkBoxO1_2.Checked = true;
            this.checkBoxO1_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxO1_2.Location = new System.Drawing.Point(1675, 783);
            this.checkBoxO1_2.Name = "checkBoxO1_2";
            this.checkBoxO1_2.Size = new System.Drawing.Size(18, 17);
            this.checkBoxO1_2.TabIndex = 10;
            this.checkBoxO1_2.UseVisualStyleBackColor = true;
            this.checkBoxO1_2.CheckedChanged += new System.EventHandler(this.checkBoxO1_2_CheckedChanged);
            // 
            // checkBoxO1_1
            // 
            this.checkBoxO1_1.AutoSize = true;
            this.checkBoxO1_1.Checked = true;
            this.checkBoxO1_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxO1_1.Location = new System.Drawing.Point(1675, 760);
            this.checkBoxO1_1.Name = "checkBoxO1_1";
            this.checkBoxO1_1.Size = new System.Drawing.Size(18, 17);
            this.checkBoxO1_1.TabIndex = 9;
            this.checkBoxO1_1.UseVisualStyleBackColor = true;
            this.checkBoxO1_1.CheckedChanged += new System.EventHandler(this.checkBoxO1_1_CheckedChanged);
            // 
            // btnIncreaseM
            // 
            this.btnIncreaseM.Location = new System.Drawing.Point(1618, 125);
            this.btnIncreaseM.Name = "btnIncreaseM";
            this.btnIncreaseM.Size = new System.Drawing.Size(75, 23);
            this.btnIncreaseM.TabIndex = 12;
            this.btnIncreaseM.Text = "M+";
            this.btnIncreaseM.UseVisualStyleBackColor = true;
            this.btnIncreaseM.Click += new System.EventHandler(this.btnIncreaseM_Click);
            // 
            // btnDecreaseM
            // 
            this.btnDecreaseM.Location = new System.Drawing.Point(1537, 125);
            this.btnDecreaseM.Name = "btnDecreaseM";
            this.btnDecreaseM.Size = new System.Drawing.Size(75, 23);
            this.btnDecreaseM.TabIndex = 13;
            this.btnDecreaseM.Text = "M-";
            this.btnDecreaseM.UseVisualStyleBackColor = true;
            this.btnDecreaseM.Click += new System.EventHandler(this.btnDecreaseM_Click);
            // 
            // FormRazdel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1754, 1055);
            this.Controls.Add(this.btnDecreaseM);
            this.Controls.Add(this.btnIncreaseM);
            this.Controls.Add(this.checkBoxO1_3);
            this.Controls.Add(this.checkBoxO1_2);
            this.Controls.Add(this.checkBoxO1_1);
            this.Controls.Add(this.checkBoxE1_3);
            this.Controls.Add(this.checkBoxE1_2);
            this.Controls.Add(this.checkBoxE1_1);
            this.Controls.Add(this.checkBoxU1_3);
            this.Controls.Add(this.checkBoxU1_2);
            this.Controls.Add(this.checkBoxU1_1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartU1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartO1;
        private System.Windows.Forms.CheckBox checkBoxU1_1;
        private System.Windows.Forms.CheckBox checkBoxU1_2;
        private System.Windows.Forms.CheckBox checkBoxU1_3;
        private System.Windows.Forms.CheckBox checkBoxE1_3;
        private System.Windows.Forms.CheckBox checkBoxE1_2;
        private System.Windows.Forms.CheckBox checkBoxE1_1;
        private System.Windows.Forms.CheckBox checkBoxO1_3;
        private System.Windows.Forms.CheckBox checkBoxO1_2;
        private System.Windows.Forms.CheckBox checkBoxO1_1;
        private System.Windows.Forms.Button btnIncreaseM;
        private System.Windows.Forms.Button btnDecreaseM;
    }
}