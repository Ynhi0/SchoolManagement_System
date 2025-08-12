namespace PL
{
    partial class EditStudentFee
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
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            lblIDStudent = new Label();
            txtIDS = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            txtTuitionFee = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dTPDuedate = new DateTimePicker();
            cmbState = new ComboBox();
            cmbMonth = new ComboBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 102);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 478);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 102);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Teal;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(508, 22);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 59);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(194, 22);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 59);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblIDStudent
            // 
            lblIDStudent.AutoSize = true;
            lblIDStudent.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDStudent.Location = new Point(92, 122);
            lblIDStudent.Name = "lblIDStudent";
            lblIDStudent.Size = new Size(138, 30);
            lblIDStudent.TabIndex = 2;
            lblIDStudent.Text = "Student's ID";
            // 
            // txtIDS
            // 
            txtIDS.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDS.Location = new Point(97, 178);
            txtIDS.Margin = new Padding(3, 4, 3, 4);
            txtIDS.Name = "txtIDS";
            txtIDS.Size = new Size(308, 37);
            txtIDS.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(452, 178);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 37);
            txtName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 122);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 4;
            label1.Text = "Student's Name";
            // 
            // txtTuitionFee
            // 
            txtTuitionFee.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTuitionFee.Location = new Point(97, 402);
            txtTuitionFee.Margin = new Padding(3, 4, 3, 4);
            txtTuitionFee.Name = "txtTuitionFee";
            txtTuitionFee.Size = new Size(308, 37);
            txtTuitionFee.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 250);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 6;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(447, 250);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 8;
            label3.Text = "DueDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 354);
            label4.Name = "label4";
            label4.Size = new Size(119, 30);
            label4.TabIndex = 10;
            label4.Text = "TuitionFee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(447, 354);
            label5.Name = "label5";
            label5.Size = new Size(66, 30);
            label5.TabIndex = 12;
            label5.Text = "State";
            // 
            // dTPDuedate
            // 
            dTPDuedate.CustomFormat = "dd/MM/yyyy";
            dTPDuedate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPDuedate.Format = DateTimePickerFormat.Custom;
            dTPDuedate.Location = new Point(452, 291);
            dTPDuedate.Margin = new Padding(3, 2, 3, 2);
            dTPDuedate.Name = "dTPDuedate";
            dTPDuedate.Size = new Size(308, 36);
            dTPDuedate.TabIndex = 31;
            // 
            // cmbState
            // 
            cmbState.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "Đã Đóng", "Chưa Đóng" });
            cmbState.Location = new Point(452, 404);
            cmbState.Margin = new Padding(3, 4, 3, 4);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(308, 38);
            cmbState.TabIndex = 44;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbMonth.Location = new Point(97, 302);
            cmbMonth.Margin = new Padding(3, 4, 3, 4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(308, 38);
            cmbMonth.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(254, 25);
            label6.Name = "label6";
            label6.Size = new Size(325, 46);
            label6.TabIndex = 0;
            label6.Text = "Student's TuitionFee";
            // 
            // EditStudentFee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 580);
            Controls.Add(cmbMonth);
            Controls.Add(cmbState);
            Controls.Add(dTPDuedate);
            Controls.Add(label5);
            Controls.Add(txtTuitionFee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtIDS);
            Controls.Add(lblIDStudent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditStudentFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditStudentFee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIDStudent;
        private System.Windows.Forms.TextBox txtIDS;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuitionFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPDuedate;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private Label label6;
    }
}