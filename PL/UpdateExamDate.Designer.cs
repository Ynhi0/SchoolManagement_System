namespace PL
{
    partial class UpdateExamDate
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
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            lblClassName = new Label();
            cmbIDClass = new ComboBox();
            dTPSpeakingTest = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dTPListeningTest = new DateTimePicker();
            label3 = new Label();
            dTPReadingTest = new DateTimePicker();
            label4 = new Label();
            dTPWritingTest = new DateTimePicker();
            lblIDClass = new Label();
            txtClassName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 144);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(168, 54);
            label5.Name = "label5";
            label5.Size = new Size(296, 46);
            label5.TabIndex = 0;
            label5.Text = "EXAM SCHEDULE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 653);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 159);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Teal;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(363, 55);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 76);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(114, 55);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 76);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(37, 260);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(181, 35);
            lblClassName.TabIndex = 2;
            lblClassName.Text = "CLASS'S NAME";
            // 
            // cmbIDClass
            // 
            cmbIDClass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbIDClass.FormattingEnabled = true;
            cmbIDClass.Location = new Point(246, 182);
            cmbIDClass.Margin = new Padding(3, 4, 3, 4);
            cmbIDClass.Name = "cmbIDClass";
            cmbIDClass.Size = new Size(367, 43);
            cmbIDClass.TabIndex = 3;
            cmbIDClass.SelectedIndexChanged += cmbIDClass_SelectedIndexChanged;
            // 
            // dTPSpeakingTest
            // 
            dTPSpeakingTest.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPSpeakingTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            dTPSpeakingTest.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPSpeakingTest.Format = DateTimePickerFormat.Custom;
            dTPSpeakingTest.Location = new Point(246, 330);
            dTPSpeakingTest.Margin = new Padding(3, 4, 3, 4);
            dTPSpeakingTest.Name = "dTPSpeakingTest";
            dTPSpeakingTest.Size = new Size(367, 41);
            dTPSpeakingTest.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 330);
            label1.Name = "label1";
            label1.Size = new Size(188, 35);
            label1.TabIndex = 5;
            label1.Text = "SPEAKING TEST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 406);
            label2.Name = "label2";
            label2.Size = new Size(194, 35);
            label2.TabIndex = 7;
            label2.Text = "LISTENING TEST";
            // 
            // dTPListeningTest
            // 
            dTPListeningTest.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPListeningTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            dTPListeningTest.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPListeningTest.Format = DateTimePickerFormat.Custom;
            dTPListeningTest.Location = new Point(246, 406);
            dTPListeningTest.Margin = new Padding(3, 4, 3, 4);
            dTPListeningTest.Name = "dTPListeningTest";
            dTPListeningTest.Size = new Size(367, 41);
            dTPListeningTest.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 478);
            label3.Name = "label3";
            label3.Size = new Size(179, 35);
            label3.TabIndex = 9;
            label3.Text = "READING TEST";
            // 
            // dTPReadingTest
            // 
            dTPReadingTest.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPReadingTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            dTPReadingTest.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPReadingTest.Format = DateTimePickerFormat.Custom;
            dTPReadingTest.Location = new Point(246, 478);
            dTPReadingTest.Margin = new Padding(3, 4, 3, 4);
            dTPReadingTest.Name = "dTPReadingTest";
            dTPReadingTest.Size = new Size(367, 41);
            dTPReadingTest.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 545);
            label4.Name = "label4";
            label4.Size = new Size(175, 35);
            label4.TabIndex = 11;
            label4.Text = "WRITING TEST";
            // 
            // dTPWritingTest
            // 
            dTPWritingTest.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPWritingTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            dTPWritingTest.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPWritingTest.Format = DateTimePickerFormat.Custom;
            dTPWritingTest.Location = new Point(246, 545);
            dTPWritingTest.Margin = new Padding(3, 4, 3, 4);
            dTPWritingTest.Name = "dTPWritingTest";
            dTPWritingTest.Size = new Size(367, 41);
            dTPWritingTest.TabIndex = 10;
            // 
            // lblIDClass
            // 
            lblIDClass.AutoSize = true;
            lblIDClass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDClass.Location = new Point(37, 186);
            lblIDClass.Name = "lblIDClass";
            lblIDClass.Size = new Size(136, 35);
            lblIDClass.TabIndex = 12;
            lblIDClass.Text = "CLASS'S ID";
            // 
            // txtClassName
            // 
            txtClassName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClassName.Location = new Point(246, 256);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(366, 41);
            txtClassName.TabIndex = 13;
            txtClassName.TextChanged += txtClassName_TextChanged;
            // 
            // UpdateExamDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 812);
            Controls.Add(txtClassName);
            Controls.Add(lblIDClass);
            Controls.Add(label4);
            Controls.Add(dTPWritingTest);
            Controls.Add(label3);
            Controls.Add(dTPReadingTest);
            Controls.Add(label2);
            Controls.Add(dTPListeningTest);
            Controls.Add(label1);
            Controls.Add(dTPSpeakingTest);
            Controls.Add(cmbIDClass);
            Controls.Add(lblClassName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateExamDate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateStudentExamSchedule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.ComboBox cmbIDClass;
        private System.Windows.Forms.DateTimePicker dTPSpeakingTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPListeningTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPReadingTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPWritingTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIDClass;
        private System.Windows.Forms.TextBox txtClassName;
    }
}