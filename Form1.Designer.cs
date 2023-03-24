
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
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRazdel1
            // 
            this.btnRazdel1.Location = new System.Drawing.Point(52, 224);
            this.btnRazdel1.Name = "btnRazdel1";
            this.btnRazdel1.Size = new System.Drawing.Size(92, 23);
            this.btnRazdel1.TabIndex = 1;
            this.btnRazdel1.Text = "Раздел 1";
            this.btnRazdel1.UseVisualStyleBackColor = true;
            this.btnRazdel1.Click += new System.EventHandler(this.btnRazdel1_Click);
            // 
            // btnRazdel2
            // 
            this.btnRazdel2.Location = new System.Drawing.Point(615, 224);
            this.btnRazdel2.Name = "btnRazdel2";
            this.btnRazdel2.Size = new System.Drawing.Size(81, 23);
            this.btnRazdel2.TabIndex = 2;
            this.btnRazdel2.Text = "Раздел 2";
            this.btnRazdel2.UseVisualStyleBackColor = true;
            this.btnRazdel2.Click += new System.EventHandler(this.btnRazdel2_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(331, 224);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(92, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 498);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnRazdel2);
            this.Controls.Add(this.btnRazdel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRazdel1;
        private System.Windows.Forms.Button btnRazdel2;
        private System.Windows.Forms.Button btnTest;
    }
}

