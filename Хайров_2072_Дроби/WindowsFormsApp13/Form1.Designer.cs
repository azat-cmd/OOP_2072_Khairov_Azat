namespace WindowsFormsApp13
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Del1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Del2 = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rav = new System.Windows.Forms.Button();
            this.Um = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.labelRav = new System.Windows.Forms.Label();
            this.Znak_Label = new System.Windows.Forms.Label();
            this.Del3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(73, 96);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(73, 20);
            this.Num1.TabIndex = 0;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // Del1
            // 
            this.Del1.Location = new System.Drawing.Point(73, 131);
            this.Del1.Name = "Del1";
            this.Del1.Size = new System.Drawing.Size(73, 20);
            this.Del1.TabIndex = 1;
            this.Del1.TextChanged += new System.EventHandler(this.Del3_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(213, 96);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(73, 20);
            this.Num2.TabIndex = 3;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Del2
            // 
            this.Del2.Location = new System.Drawing.Point(213, 131);
            this.Del2.Name = "Del2";
            this.Del2.Size = new System.Drawing.Size(73, 20);
            this.Del2.TabIndex = 2;
            this.Del2.TextChanged += new System.EventHandler(this.Del3_TextChanged);
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(370, 96);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(100, 20);
            this.Num3.TabIndex = 4;
            this.Num3.TextChanged += new System.EventHandler(this.Num3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rav);
            this.groupBox1.Controls.Add(this.Um);
            this.groupBox1.Controls.Add(this.Del);
            this.groupBox1.Controls.Add(this.Minus);
            this.groupBox1.Controls.Add(this.Plus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(70, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rav
            // 
            this.Rav.Location = new System.Drawing.Point(155, 33);
            this.Rav.Name = "Rav";
            this.Rav.Size = new System.Drawing.Size(55, 83);
            this.Rav.TabIndex = 8;
            this.Rav.Text = "=";
            this.Rav.UseVisualStyleBackColor = true;
            this.Rav.Click += new System.EventHandler(this.ravno_Click);
            // 
            // Um
            // 
            this.Um.Location = new System.Drawing.Point(94, 82);
            this.Um.Name = "Um";
            this.Um.Size = new System.Drawing.Size(55, 29);
            this.Um.TabIndex = 7;
            this.Um.Text = "*";
            this.Um.UseVisualStyleBackColor = true;
            this.Um.Click += new System.EventHandler(this.um_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(94, 33);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(55, 29);
            this.Del.TabIndex = 7;
            this.Del.Text = "/";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.del_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(17, 82);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(55, 29);
            this.Minus.TabIndex = 7;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(17, 33);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(55, 29);
            this.Plus.TabIndex = 6;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // labelRav
            // 
            this.labelRav.AutoSize = true;
            this.labelRav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRav.Location = new System.Drawing.Point(321, 113);
            this.labelRav.Name = "labelRav";
            this.labelRav.Size = new System.Drawing.Size(16, 17);
            this.labelRav.TabIndex = 6;
            this.labelRav.Text = "=";
            // 
            // Znak_Label
            // 
            this.Znak_Label.AutoSize = true;
            this.Znak_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Znak_Label.Location = new System.Drawing.Point(173, 117);
            this.Znak_Label.Name = "Znak_Label";
            this.Znak_Label.Size = new System.Drawing.Size(16, 17);
            this.Znak_Label.TabIndex = 7;
            this.Znak_Label.Text = "+";
            // 
            // Del3
            // 
            this.Del3.Location = new System.Drawing.Point(370, 131);
            this.Del3.Name = "Del3";
            this.Del3.Size = new System.Drawing.Size(100, 20);
            this.Del3.TabIndex = 8;
            this.Del3.TextChanged += new System.EventHandler(this.Del3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Del3);
            this.Controls.Add(this.Znak_Label);
            this.Controls.Add(this.labelRav);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Del2);
            this.Controls.Add(this.Del1);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Del1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Del2;
        private System.Windows.Forms.TextBox Num3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Rav;
        private System.Windows.Forms.Button Um;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Label labelRav;
        private System.Windows.Forms.Label Znak_Label;
        private System.Windows.Forms.TextBox Del3;
    }
}

