namespace StudyAssist
{
    partial class Notes
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
            subjectBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            prevNotes = new DataGridView();
            saveButton = new Button();
            deleteButton = new Button();
            button1 = new Button();
            loadButton = new Button();
            newButton = new Button();
            ((System.ComponentModel.ISupportInitialize)prevNotes).BeginInit();
            SuspendLayout();
            // 
            // subjectBox
            // 
            subjectBox.Location = new Point(35, 46);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new Size(662, 27);
            subjectBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(35, 110);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(662, 531);
            noteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(662, 25);
            label1.TabIndex = 2;
            label1.Text = "Subject:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(662, 25);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // prevNotes
            // 
            prevNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prevNotes.BackgroundColor = SystemColors.ButtonFace;
            prevNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prevNotes.Location = new Point(733, 46);
            prevNotes.Name = "prevNotes";
            prevNotes.RowHeadersWidth = 51;
            prevNotes.Size = new Size(521, 453);
            prevNotes.TabIndex = 4;
            prevNotes.CellDoubleClick += prevNotes_CellDoubleClick;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.PowderBlue;
            saveButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.FromArgb(0, 0, 64);
            saveButton.Location = new Point(733, 515);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 49);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.PowderBlue;
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.FromArgb(0, 0, 64);
            deleteButton.Location = new Point(1002, 515);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(120, 49);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(960, 606);
            button1.Name = "button1";
            button1.Size = new Size(73, 35);
            button1.TabIndex = 9;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.PowderBlue;
            loadButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadButton.ForeColor = Color.FromArgb(0, 0, 64);
            loadButton.Location = new Point(866, 515);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(120, 49);
            loadButton.TabIndex = 10;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // newButton
            // 
            newButton.BackColor = Color.PowderBlue;
            newButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newButton.ForeColor = Color.FromArgb(0, 0, 64);
            newButton.Location = new Point(1134, 515);
            newButton.Name = "newButton";
            newButton.Size = new Size(120, 49);
            newButton.TabIndex = 11;
            newButton.Text = "New Note";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1282, 653);
            ControlBox = false;
            Controls.Add(newButton);
            Controls.Add(loadButton);
            Controls.Add(button1);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(prevNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(subjectBox);
            Name = "Notes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            Load += Notes_Load;
            ((System.ComponentModel.ISupportInitialize)prevNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox subjectBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView prevNotes;
        private Button saveButton;
        private Button deleteButton;
        private Button button1;
        private Button loadButton;
        private Button newButton;
    }
}