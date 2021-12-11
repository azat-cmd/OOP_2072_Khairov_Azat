namespace WindowsFormsApp14
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.move_button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rad = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 76);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rectangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(20, 40);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(454, 386);
            this.DrawPanel.TabIndex = 3;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 76);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wagon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 76);
            this.button4.TabIndex = 5;
            this.button4.Text = "Coal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 76);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sand";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // move_button
            // 
            this.move_button.Location = new System.Drawing.Point(707, 142);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(72, 76);
            this.move_button.TabIndex = 7;
            this.move_button.Text = "Move";
            this.move_button.UseVisualStyleBackColor = true;
            this.move_button.Click += new System.EventHandler(this.move_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(707, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 76);
            this.button6.TabIndex = 8;
            this.button6.Text = "Train";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // rad
            // 
            this.rad.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rad.Location = new System.Drawing.Point(499, 87);
            this.rad.Name = "rad";
            this.rad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad.Size = new System.Drawing.Size(57, 22);
            this.rad.TabIndex = 9;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(499, 128);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(57, 20);
            this.width.TabIndex = 10;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(499, 171);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(57, 20);
            this.height.TabIndex = 11;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(499, 211);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(57, 20);
            this.count.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(509, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Count";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(725, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 43);
            this.button7.TabIndex = 17;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(499, 272);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.move_button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox rad;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

