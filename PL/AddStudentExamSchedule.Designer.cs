namespace PL
{
    partial class AddStudentExamSchedule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.cmbIDClass = new System.Windows.Forms.ComboBox();
            this.dTPSpeakingTest = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPListeningTest = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPReadingTest = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPWritingTest = new System.Windows.Forms.DateTimePicker();
            this.lblIDClass = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 115);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "EXAM SCHEDULE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 127);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(363, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 61);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(114, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 61);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(37, 208);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(181, 35);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "CLASS\'S NAME";
            // 
            // cmbIDClass
            // 
            this.cmbIDClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDClass.FormattingEnabled = true;
            this.cmbIDClass.Location = new System.Drawing.Point(246, 146);
            this.cmbIDClass.Name = "cmbIDClass";
            this.cmbIDClass.Size = new System.Drawing.Size(367, 43);
            this.cmbIDClass.TabIndex = 3;
            this.cmbIDClass.SelectedIndexChanged += new System.EventHandler(this.cmbIDClass_SelectedIndexChanged);
            // 
            // dTPSpeakingTest
            // 
            this.dTPSpeakingTest.CalendarFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPSpeakingTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dTPSpeakingTest.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPSpeakingTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPSpeakingTest.Location = new System.Drawing.Point(246, 264);
            this.dTPSpeakingTest.Name = "dTPSpeakingTest";
            this.dTPSpeakingTest.Size = new System.Drawing.Size(367, 41);
            this.dTPSpeakingTest.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "SPEAKING TEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "LISTENING TEST";
            // 
            // dTPListeningTest
            // 
            this.dTPListeningTest.CalendarFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPListeningTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dTPListeningTest.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPListeningTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPListeningTest.Location = new System.Drawing.Point(246, 325);
            this.dTPListeningTest.Name = "dTPListeningTest";
            this.dTPListeningTest.Size = new System.Drawing.Size(367, 41);
            this.dTPListeningTest.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "READING TEST";
            // 
            // dTPReadingTest
            // 
            this.dTPReadingTest.CalendarFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPReadingTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dTPReadingTest.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPReadingTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPReadingTest.Location = new System.Drawing.Point(246, 382);
            this.dTPReadingTest.Name = "dTPReadingTest";
            this.dTPReadingTest.Size = new System.Drawing.Size(367, 41);
            this.dTPReadingTest.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "WRITING TEST";
            // 
            // dTPWritingTest
            // 
            this.dTPWritingTest.CalendarFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPWritingTest.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dTPWritingTest.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPWritingTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPWritingTest.Location = new System.Drawing.Point(246, 436);
            this.dTPWritingTest.Name = "dTPWritingTest";
            this.dTPWritingTest.Size = new System.Drawing.Size(367, 41);
            this.dTPWritingTest.TabIndex = 10;
            // 
            // lblIDClass
            // 
            this.lblIDClass.AutoSize = true;
            this.lblIDClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDClass.Location = new System.Drawing.Point(37, 149);
            this.lblIDClass.Name = "lblIDClass";
            this.lblIDClass.Size = new System.Drawing.Size(136, 35);
            this.lblIDClass.TabIndex = 12;
            this.lblIDClass.Text = "CLASS\'S ID";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(246, 205);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(366, 41);
            this.txtClassName.TabIndex = 13;
            // 
            // AddStudentExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblIDClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPWritingTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPReadingTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPListeningTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPSpeakingTest);
            this.Controls.Add(this.cmbIDClass);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentExamSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentExamSchedule";
            this.Load += new System.EventHandler(this.AddStudentExamSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
