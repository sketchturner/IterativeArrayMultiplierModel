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
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbTruncated = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbADec
            // 
            this.tbADec.Location = new System.Drawing.Point(12, 12);
            this.tbADec.Name = "tbADec";
            this.tbADec.Size = new System.Drawing.Size(100, 20);
            this.tbADec.TabIndex = 0;
            this.tbADec.TextChanged += new System.EventHandler(this.tbADec_TextChanged);
            // 
            // tbABin
            // 
            this.tbABin.Enabled = false;
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
            this.tbBDec.TextChanged += new System.EventHandler(this.tbBDec_TextChanged);
            // 
            // tbBBin
            // 
            this.tbBBin.Enabled = false;
            this.tbBBin.Location = new System.Drawing.Point(119, 39);
            this.tbBBin.Name = "tbBBin";
            this.tbBBin.Size = new System.Drawing.Size(100, 20);
            this.tbBBin.TabIndex = 3;
            // 
            // tbResDec
            // 
            this.tbResDec.Enabled = false;
            this.tbResDec.Location = new System.Drawing.Point(12, 116);
            this.tbResDec.Name = "tbResDec";
            this.tbResDec.Size = new System.Drawing.Size(100, 20);
            this.tbResDec.TabIndex = 4;
            this.tbResDec.TextChanged += new System.EventHandler(this.tbResDec_TextChanged);
            // 
            // tbResBin
            // 
            this.tbResBin.Enabled = false;
            this.tbResBin.Location = new System.Drawing.Point(12, 142);
            this.tbResBin.Name = "tbResBin";
            this.tbResBin.Size = new System.Drawing.Size(100, 20);
            this.tbResBin.TabIndex = 5;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(37, 77);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "Умножить";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(486, 17);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(34, 20);
            this.tbWidth.TabIndex = 7;
            this.tbWidth.Text = "4";
            // 
            // tbTruncated
            // 
            this.tbTruncated.Location = new System.Drawing.Point(486, 44);
            this.tbTruncated.Name = "tbTruncated";
            this.tbTruncated.Size = new System.Drawing.Size(34, 20);
            this.tbTruncated.TabIndex = 8;
            this.tbTruncated.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbShort);
            this.groupBox1.Controls.Add(this.rbFull);
            this.groupBox1.Location = new System.Drawing.Point(250, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplication";
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Checked = true;
            this.rbFull.Location = new System.Drawing.Point(7, 19);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(41, 17);
            this.rbFull.TabIndex = 0;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full";
            this.rbFull.UseVisualStyleBackColor = true;
            // 
            // rbShort
            // 
            this.rbShort.AutoSize = true;
            this.rbShort.Location = new System.Drawing.Point(7, 42);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(50, 17);
            this.rbShort.TabIndex = 1;
            this.rbShort.Text = "Short";
            this.rbShort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Truncated";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTruncated);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.tbResBin);
            this.Controls.Add(this.tbResDec);
            this.Controls.Add(this.tbBBin);
            this.Controls.Add(this.tbBDec);
            this.Controls.Add(this.tbABin);
            this.Controls.Add(this.tbADec);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbTruncated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbShort;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

