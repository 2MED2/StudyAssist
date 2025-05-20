namespace StudyAssist
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold);
            button1.ForeColor = Color.CadetBlue;
            button1.Location = new Point(1000, 123);
            button1.Name = "button1";
            button1.Size = new Size(225, 100);
            button1.TabIndex = 0;
            button1.Text = "Notes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.CadetBlue;
            button2.Location = new Point(52, 123);
            button2.Name = "button2";
            button2.Size = new Size(225, 100);
            button2.TabIndex = 1;
            button2.Text = "Timer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.CadetBlue;
            button3.Location = new Point(52, 276);
            button3.Name = "button3";
            button3.Size = new Size(225, 100);
            button3.TabIndex = 2;
            button3.Text = "Calculator";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold);
            button4.ForeColor = Color.CadetBlue;
            button4.Location = new Point(52, 428);
            button4.Name = "button4";
            button4.Size = new Size(225, 100);
            button4.TabIndex = 3;
            button4.Text = "Converter";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold);
            button6.ForeColor = Color.CadetBlue;
            button6.Location = new Point(1000, 428);
            button6.Name = "button6";
            button6.Size = new Size(225, 100);
            button6.TabIndex = 4;
            button6.Text = "Draw";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold);
            button5.ForeColor = Color.CadetBlue;
            button5.Location = new Point(1000, 276);
            button5.Name = "button5";
            button5.Size = new Size(225, 100);
            button5.TabIndex = 5;
            button5.Text = "To-Do List";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(413, 20);
            label1.Name = "label1";
            label1.Size = new Size(449, 67);
            label1.TabIndex = 6;
            label1.Text = "STUDY ASSIST";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1282, 653);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Label label1;
    }
}
