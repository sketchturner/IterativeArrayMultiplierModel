namespace MatrixMultiplier
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbADec = new System.Windows.Forms.TextBox();
            this.tbABin = new System.Windows.Forms.TextBox();
            this.tbBDec = new System.Windows.Forms.TextBox();
            this.tbBBin = new System.Windows.Forms.TextBox();
            this.tbResDec = new System.Windows.Forms.TextBox();
            this.tbResBin = new System.Windows.Forms.TextBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbADec
            // 
            this.tbADec.Location = new System.Drawing.Point(12, 12);
            this.tbADec.Name = "tbADec";
            this.tbADec.Size = new System.Drawing.Size(100, 20);
            this.tbADec.TabIndex = 0;
            // 
            // tbABin
            // 
            this.tbABin.Location = new System.Drawing.Point(12, 39);
            this.tbABin.Name = "tbABin";
            this.tbABin.Size = new System.Drawing.Size(100, 20);
            this.tbABin.TabIndex = 1;
            // 
            // tbBDec
            // 
            this.tbBDec.Location = new System.Drawing.Point(119, 12);
            this.tbBDec.Name = "tbBDec";
            this.tbBDec.Size = new System.Drawing.Size(100, 20);
            this.tbBDec.TabIndex = 2;
            // 
            // tbBBin
            // 
            this.tbBBin.Location = new System.Drawing.Point(119, 39);
            this.tbBBin.Name = "tbBBin";
            this.tbBBin.Size = new System.Drawing.Size(100, 20);
            this.tbBBin.TabIndex = 3;
            // 
            // tbResDec
            // 
            this.tbResDec.Location = new System.Drawing.Point(12, 116);
            this.tbResDec.Name = "tbResDec";
            this.tbResDec.Size = new System.Drawing.Size(100, 20);
            this.tbResDec.TabIndex = 4;
            // 
            // tbResBin
            // 
            this.tbResBin.Location = new System.Drawing.Point(119, 116);
            this.tbResBin.Name = "tbResBin";
            this.tbResBin.Size = new System.Drawing.Size(100, 20);
            this.tbResBin.TabIndex = 5;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(119, 77);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "Умножить";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 305);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.tbResBin);
            this.Controls.Add(this.tbResDec);
            this.Controls.Add(this.tbBBin);
            this.Controls.Add(this.tbBDec);
            this.Controls.Add(this.tbABin);
            this.Controls.Add(this.tbADec);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbADec;
        private System.Windows.Forms.TextBox tbABin;
        private System.Windows.Forms.TextBox tbBDec;
        private System.Windows.Forms.TextBox tbBBin;
        private System.Windows.Forms.TextBox tbResDec;
        private System.Windows.Forms.TextBox tbResBin;
        private System.Windows.Forms.Button btnMult;
    }
}

