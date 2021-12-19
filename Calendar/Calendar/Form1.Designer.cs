
namespace Calendar
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
            this.NextDateButton = new System.Windows.Forms.Button();
            this.SetDateButton = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.y = new System.Windows.Forms.NumericUpDown();
            this.z = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).BeginInit();
            this.SuspendLayout();
            // 
            // NextDateButton
            // 
            this.NextDateButton.Enabled = false;
            this.NextDateButton.Location = new System.Drawing.Point(61, 131);
            this.NextDateButton.Name = "NextDateButton";
            this.NextDateButton.Size = new System.Drawing.Size(78, 34);
            this.NextDateButton.TabIndex = 3;
            this.NextDateButton.Text = "NextDate";
            this.NextDateButton.UseVisualStyleBackColor = true;
            this.NextDateButton.Click += new System.EventHandler(this.NextDateButton_Click);
            // 
            // SetDateButton
            // 
            this.SetDateButton.Location = new System.Drawing.Point(66, 190);
            this.SetDateButton.Name = "SetDateButton";
            this.SetDateButton.Size = new System.Drawing.Size(72, 26);
            this.SetDateButton.TabIndex = 4;
            this.SetDateButton.Text = "SetDate";
            this.SetDateButton.UseVisualStyleBackColor = true;
            this.SetDateButton.Click += new System.EventHandler(this.SetDateButton_Click);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(66, 68);
            this.x.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(69, 20);
            this.x.TabIndex = 5;
            this.x.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(166, 68);
            this.y.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(69, 20);
            this.y.TabIndex = 6;
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(275, 68);
            this.z.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(69, 20);
            this.z.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.SetDateButton);
            this.Controls.Add(this.NextDateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextDateButton;
        private System.Windows.Forms.Button SetDateButton;
        private System.Windows.Forms.NumericUpDown x;
        private System.Windows.Forms.NumericUpDown y;
        private System.Windows.Forms.NumericUpDown z;
    }
}

