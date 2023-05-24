
namespace Spectres
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRazdel1 = new System.Windows.Forms.Button();
            this.btnRazdel2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTeor1 = new System.Windows.Forms.Button();
            this.btnTeor2 = new System.Windows.Forms.Button();
            this.tb1M1 = new System.Windows.Forms.TextBox();
            this.tb1M2 = new System.Windows.Forms.TextBox();
            this.tb1M3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb2N = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb2M = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbParamA = new System.Windows.Forms.TextBox();
            this.tbParamTau = new System.Windows.Forms.TextBox();
            this.tbParamK = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRazdel1
            // 
            this.btnRazdel1.Location = new System.Drawing.Point(359, 214);
            this.btnRazdel1.Name = "btnRazdel1";
            this.btnRazdel1.Size = new System.Drawing.Size(130, 23);
            this.btnRazdel1.TabIndex = 1;
            this.btnRazdel1.Text = "Моделировать";
            this.btnRazdel1.UseVisualStyleBackColor = true;
            this.btnRazdel1.Click += new System.EventHandler(this.btnRazdel1_Click);
            // 
            // btnRazdel2
            // 
            this.btnRazdel2.Location = new System.Drawing.Point(383, 140);
            this.btnRazdel2.Name = "btnRazdel2";
            this.btnRazdel2.Size = new System.Drawing.Size(130, 23);
            this.btnRazdel2.TabIndex = 2;
            this.btnRazdel2.Text = "Моделировать";
            this.btnRazdel2.UseVisualStyleBackColor = true;
            this.btnRazdel2.Click += new System.EventHandler(this.btnRazdel2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1154, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Лабораторная работа. Трансформация спектров видеоимпульсов и радиоимпульсов.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Раздел А - Расщепление спектров видеоимпульсов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(723, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Раздел Б  Дискретно-непрерывная трансформация\r\n спектров видео- и радиоимпульсов";
            // 
            // btnTeor1
            // 
            this.btnTeor1.Location = new System.Drawing.Point(15, 21);
            this.btnTeor1.Name = "btnTeor1";
            this.btnTeor1.Size = new System.Drawing.Size(489, 32);
            this.btnTeor1.TabIndex = 8;
            this.btnTeor1.Text = "Теоретические данные";
            this.btnTeor1.UseVisualStyleBackColor = true;
            // 
            // btnTeor2
            // 
            this.btnTeor2.Location = new System.Drawing.Point(6, 21);
            this.btnTeor2.Name = "btnTeor2";
            this.btnTeor2.Size = new System.Drawing.Size(537, 32);
            this.btnTeor2.TabIndex = 9;
            this.btnTeor2.Text = "Теоретические данные";
            this.btnTeor2.UseVisualStyleBackColor = true;
            // 
            // tb1M1
            // 
            this.tb1M1.Location = new System.Drawing.Point(389, 82);
            this.tb1M1.MaxLength = 5;
            this.tb1M1.Name = "tb1M1";
            this.tb1M1.Size = new System.Drawing.Size(100, 22);
            this.tb1M1.TabIndex = 10;
            this.tb1M1.Text = "0";
            // 
            // tb1M2
            // 
            this.tb1M2.Location = new System.Drawing.Point(389, 110);
            this.tb1M2.MaxLength = 5;
            this.tb1M2.Name = "tb1M2";
            this.tb1M2.Size = new System.Drawing.Size(100, 22);
            this.tb1M2.TabIndex = 11;
            this.tb1M2.Text = "1";
            // 
            // tb1M3
            // 
            this.tb1M3.Location = new System.Drawing.Point(389, 138);
            this.tb1M3.MaxLength = 5;
            this.tb1M3.Name = "tb1M3";
            this.tb1M3.Size = new System.Drawing.Size(100, 22);
            this.tb1M3.TabIndex = 12;
            this.tb1M3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Значения параметра М:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRazdel1);
            this.groupBox1.Controls.Add(this.btnTeor1);
            this.groupBox1.Controls.Add(this.tb1M1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb1M2);
            this.groupBox1.Controls.Add(this.tb1M3);
            this.groupBox1.Location = new System.Drawing.Point(18, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 321);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb2N);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb2M);
            this.groupBox2.Controls.Add(this.btnTeor2);
            this.groupBox2.Controls.Add(this.btnRazdel2);
            this.groupBox2.Location = new System.Drawing.Point(728, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 321);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Значение параметра N:";
            // 
            // tb2N
            // 
            this.tb2N.Location = new System.Drawing.Point(413, 109);
            this.tb2N.Name = "tb2N";
            this.tb2N.Size = new System.Drawing.Size(100, 22);
            this.tb2N.TabIndex = 15;
            this.tb2N.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Значение параметра М:";
            // 
            // tb2M
            // 
            this.tb2M.Location = new System.Drawing.Point(413, 81);
            this.tb2M.Name = "tb2M";
            this.tb2M.Size = new System.Drawing.Size(100, 22);
            this.tb2M.TabIndex = 10;
            this.tb2M.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbParamK);
            this.groupBox3.Controls.Add(this.tbParamTau);
            this.groupBox3.Controls.Add(this.tbParamA);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(398, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 56);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общие параметры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "А";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(147, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "tau";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(298, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "K";
            // 
            // tbParamA
            // 
            this.tbParamA.Location = new System.Drawing.Point(41, 20);
            this.tbParamA.Name = "tbParamA";
            this.tbParamA.Size = new System.Drawing.Size(100, 22);
            this.tbParamA.TabIndex = 20;
            this.tbParamA.Text = "2";
            // 
            // tbParamTau
            // 
            this.tbParamTau.Location = new System.Drawing.Point(192, 20);
            this.tbParamTau.Name = "tbParamTau";
            this.tbParamTau.Size = new System.Drawing.Size(100, 22);
            this.tbParamTau.TabIndex = 21;
            this.tbParamTau.Text = "2e-6";
            // 
            // tbParamK
            // 
            this.tbParamK.Location = new System.Drawing.Point(333, 18);
            this.tbParamK.Name = "tbParamK";
            this.tbParamK.Size = new System.Drawing.Size(100, 22);
            this.tbParamK.TabIndex = 22;
            this.tbParamK.Text = "8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRazdel1;
        private System.Windows.Forms.Button btnRazdel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTeor1;
        private System.Windows.Forms.Button btnTeor2;
        private System.Windows.Forms.TextBox tb1M1;
        private System.Windows.Forms.TextBox tb1M2;
        private System.Windows.Forms.TextBox tb1M3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb2M;
        private System.Windows.Forms.TextBox tb2N;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbParamK;
        private System.Windows.Forms.TextBox tbParamTau;
        private System.Windows.Forms.TextBox tbParamA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

