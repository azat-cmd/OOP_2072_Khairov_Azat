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
            this.button3.Text = "Telega";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 76);
            this.button4.TabIndex = 5;
            this.button4.Text = "Telega_s_uglem";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 76);
            this.button5.TabIndex = 6;
            this.button5.Text = "Telega_s_kamnem";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // move_button
            // 
            this.move_button.Location = new System.Drawing.Point(693, 163);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(72, 76);
            this.move_button.TabIndex = 7;
            this.move_button.Text = "Move";
            this.move_button.UseVisualStyleBackColor = true;
            this.move_button.Click += new System.EventHandler(this.move_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.move_button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button move_button;
    }
}

