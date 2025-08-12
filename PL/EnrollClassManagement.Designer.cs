namespace PL
{
    partial class EnrollClassManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            btnClass = new Button();
            btnExamSchedule = new Button();
            btnEnrollClass = new Button();
            btnTimeTable = new Button();
            btnReturn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            cmbRoom = new ComboBox();
            lblRoom = new Label();
            cmbTimeTable = new ComboBox();
            lblTimeTable = new Label();
            cmbTeacherID = new ComboBox();
            lblTeacherName = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            txtTeacherName = new TextBox();
            txtNumberOfStudent = new TextBox();
            cmbBoxState = new ComboBox();
            cmbClassShift = new ComboBox();
            dTPEndDate = new DateTimePicker();
            dTPStartDate = new DateTimePicker();
            txtClassName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            lblTeacherID = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtIDclass = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            dataGridViewClass = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(296, 44);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 19;
            label2.Text = "Enroll Class";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnClass);
            panel4.Controls.Add(btnExamSchedule);
            panel4.Controls.Add(btnEnrollClass);
            panel4.Controls.Add(btnTimeTable);
            panel4.Controls.Add(btnReturn);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 43);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 747);
            panel4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(78, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnClass
            // 
            btnClass.BackColor = Color.Teal;
            btnClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClass.ForeColor = Color.White;
            btnClass.Location = new Point(62, 241);
            btnClass.Margin = new Padding(3, 2, 3, 2);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(170, 66);
            btnClass.TabIndex = 1;
            btnClass.Text = "Class";
            btnClass.UseVisualStyleBackColor = false;
            btnClass.Click += btnClass_Click;
            // 
            // btnExamSchedule
            // 
            btnExamSchedule.BackColor = Color.Teal;
            btnExamSchedule.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExamSchedule.ForeColor = Color.White;
            btnExamSchedule.Location = new Point(62, 497);
            btnExamSchedule.Margin = new Padding(3, 2, 3, 2);
            btnExamSchedule.Name = "btnExamSchedule";
            btnExamSchedule.Size = new Size(170, 66);
            btnExamSchedule.TabIndex = 4;
            btnExamSchedule.Text = "Exam schedule";
            btnExamSchedule.UseVisualStyleBackColor = false;
            btnExamSchedule.Click += btnExamSchedule_Click;
            // 
            // btnEnrollClass
            // 
            btnEnrollClass.BackColor = Color.Teal;
            btnEnrollClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollClass.ForeColor = Color.White;
            btnEnrollClass.Location = new Point(62, 318);
            btnEnrollClass.Margin = new Padding(3, 2, 3, 2);
            btnEnrollClass.Name = "btnEnrollClass";
            btnEnrollClass.Size = new Size(170, 66);
            btnEnrollClass.TabIndex = 2;
            btnEnrollClass.Text = "Enroll Class";
            btnEnrollClass.UseVisualStyleBackColor = false;
            // 
            // btnTimeTable
            // 
            btnTimeTable.BackColor = Color.Teal;
            btnTimeTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeTable.ForeColor = Color.White;
            btnTimeTable.Location = new Point(62, 406);
            btnTimeTable.Margin = new Padding(3, 2, 3, 2);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Size = new Size(170, 66);
            btnTimeTable.TabIndex = 3;
            btnTimeTable.Text = "TimeTable";
            btnTimeTable.UseVisualStyleBackColor = false;
            btnTimeTable.Click += btnTimeTable_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Teal;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(62, 612);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(170, 66);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(318, 87);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 997);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbRoom);
            panel3.Controls.Add(lblRoom);
            panel3.Controls.Add(cmbTimeTable);
            panel3.Controls.Add(lblTimeTable);
            panel3.Controls.Add(cmbTeacherID);
            panel3.Controls.Add(lblTeacherName);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtTeacherName);
            panel3.Controls.Add(txtNumberOfStudent);
            panel3.Controls.Add(cmbBoxState);
            panel3.Controls.Add(cmbClassShift);
            panel3.Controls.Add(dTPEndDate);
            panel3.Controls.Add(dTPStartDate);
            panel3.Controls.Add(txtClassName);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblTeacherID);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtIDclass);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(51, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1052, 379);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // cmbRoom
            // 
            cmbRoom.Font = new Font("Segoe UI", 10F);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbRoom.Location = new Point(205, 269);
            cmbRoom.Margin = new Padding(3, 4, 3, 4);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(283, 31);
            cmbRoom.TabIndex = 43;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 10F);
            lblRoom.Location = new Point(42, 269);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(61, 23);
            lblRoom.TabIndex = 42;
            lblRoom.Text = "ROOM";
            // 
            // cmbTimeTable
            // 
            cmbTimeTable.Font = new Font("Segoe UI", 10F);
            cmbTimeTable.FormattingEnabled = true;
            cmbTimeTable.Items.AddRange(new object[] { "2-4-6", "3-5-7" });
            cmbTimeTable.Location = new Point(665, 211);
            cmbTimeTable.Margin = new Padding(3, 4, 3, 4);
            cmbTimeTable.Name = "cmbTimeTable";
            cmbTimeTable.Size = new Size(291, 31);
            cmbTimeTable.TabIndex = 41;
            // 
            // lblTimeTable
            // 
            lblTimeTable.AutoSize = true;
            lblTimeTable.Font = new Font("Segoe UI", 10F);
            lblTimeTable.Location = new Point(501, 208);
            lblTimeTable.Name = "lblTimeTable";
            lblTimeTable.Size = new Size(94, 23);
            lblTimeTable.TabIndex = 40;
            lblTimeTable.Text = "TIMETABLE";
            // 
            // cmbTeacherID
            // 
            cmbTeacherID.Font = new Font("Segoe UI", 10F);
            cmbTeacherID.FormattingEnabled = true;
            cmbTeacherID.Location = new Point(205, 208);
            cmbTeacherID.Margin = new Padding(3, 4, 3, 4);
            cmbTeacherID.Name = "cmbTeacherID";
            cmbTeacherID.Size = new Size(283, 31);
            cmbTeacherID.TabIndex = 39;
            cmbTeacherID.SelectedIndexChanged += cmbTeacherID_SelectedIndexChanged;
            // 
            // lblTeacherName
            // 
            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new Font("Segoe UI", 10F);
            lblTeacherName.Location = new Point(39, 208);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(97, 23);
            lblTeacherName.TabIndex = 37;
            lblTeacherName.Text = "IDTEACHER";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Teal;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(570, 308);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 59);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(328, 308);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 59);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTeacherName
            // 
            txtTeacherName.Font = new Font("Segoe UI", 10F);
            txtTeacherName.Location = new Point(205, 153);
            txtTeacherName.Margin = new Padding(3, 4, 3, 4);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(283, 30);
            txtTeacherName.TabIndex = 34;
            // 
            // txtNumberOfStudent
            // 
            txtNumberOfStudent.Font = new Font("Segoe UI", 10F);
            txtNumberOfStudent.Location = new Point(251, 100);
            txtNumberOfStudent.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfStudent.Name = "txtNumberOfStudent";
            txtNumberOfStudent.Size = new Size(237, 30);
            txtNumberOfStudent.TabIndex = 33;
            // 
            // cmbBoxState
            // 
            cmbBoxState.Font = new Font("Segoe UI", 10F);
            cmbBoxState.FormattingEnabled = true;
            cmbBoxState.Items.AddRange(new object[] { "Đang Hoạt Động", "Đã Kết Thúc" });
            cmbBoxState.Location = new Point(665, 149);
            cmbBoxState.Margin = new Padding(3, 4, 3, 4);
            cmbBoxState.Name = "cmbBoxState";
            cmbBoxState.Size = new Size(291, 31);
            cmbBoxState.TabIndex = 32;
            // 
            // cmbClassShift
            // 
            cmbClassShift.Font = new Font("Segoe UI", 10F);
            cmbClassShift.FormattingEnabled = true;
            cmbClassShift.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbClassShift.Location = new Point(664, 100);
            cmbClassShift.Margin = new Padding(3, 4, 3, 4);
            cmbClassShift.Name = "cmbClassShift";
            cmbClassShift.Size = new Size(290, 31);
            cmbClassShift.TabIndex = 31;
            cmbClassShift.SelectedIndexChanged += cmbClassShift_SelectedIndexChanged;
            // 
            // dTPEndDate
            // 
            dTPEndDate.CustomFormat = "dd/MM/yyyy";
            dTPEndDate.Font = new Font("Segoe UI", 10F);
            dTPEndDate.Format = DateTimePickerFormat.Custom;
            dTPEndDate.Location = new Point(664, 58);
            dTPEndDate.Margin = new Padding(3, 2, 3, 2);
            dTPEndDate.Name = "dTPEndDate";
            dTPEndDate.Size = new Size(291, 30);
            dTPEndDate.TabIndex = 30;
            // 
            // dTPStartDate
            // 
            dTPStartDate.CustomFormat = "dd/MM/yyyy";
            dTPStartDate.Font = new Font("Segoe UI", 10F);
            dTPStartDate.Format = DateTimePickerFormat.Custom;
            dTPStartDate.Location = new Point(197, 58);
            dTPStartDate.Margin = new Padding(3, 2, 3, 2);
            dTPStartDate.Name = "dTPStartDate";
            dTPStartDate.Size = new Size(291, 30);
            dTPStartDate.TabIndex = 29;
            // 
            // txtClassName
            // 
            txtClassName.Font = new Font("Segoe UI", 10F);
            txtClassName.Location = new Point(665, 14);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(291, 30);
            txtClassName.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(501, 100);
            label10.Name = "label10";
            label10.Size = new Size(106, 23);
            label10.TabIndex = 8;
            label10.Text = "CLASS SHIFT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(501, 153);
            label9.Name = "label9";
            label9.Size = new Size(55, 23);
            label9.TabIndex = 7;
            label9.Text = "STATE";
            // 
            // lblTeacherID
            // 
            lblTeacherID.AutoSize = true;
            lblTeacherID.Font = new Font("Segoe UI", 10F);
            lblTeacherID.Location = new Point(34, 152);
            lblTeacherID.Name = "lblTeacherID";
            lblTeacherID.Size = new Size(142, 23);
            lblTeacherID.TabIndex = 6;
            lblTeacherID.Text = "TEACHER'SNAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(500, 20);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 5;
            label7.Text = "CLASSNAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(34, 100);
            label6.Name = "label6";
            label6.Size = new Size(183, 23);
            label6.TabIndex = 4;
            label6.Text = "NUMBER OF STUDENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(500, 58);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 3;
            label5.Text = "ENDDATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(34, 58);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 2;
            label4.Text = "STARTDATE";
            // 
            // txtIDclass
            // 
            txtIDclass.Font = new Font("Segoe UI", 10F);
            txtIDclass.Location = new Point(197, 11);
            txtIDclass.Margin = new Padding(3, 4, 3, 4);
            txtIDclass.Name = "txtIDclass";
            txtIDclass.Size = new Size(291, 30);
            txtIDclass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 14);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 0;
            label3.Text = "IDCLASS";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridViewClass);
            panel5.Location = new Point(51, 389);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1052, 483);
            panel5.TabIndex = 1;
            // 
            // dataGridViewClass
            // 
            dataGridViewClass.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClass.EnableHeadersVisualStyles = false;
            dataGridViewClass.Location = new Point(-1, -1);
            dataGridViewClass.Margin = new Padding(3, 2, 3, 2);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.RowHeadersWidth = 51;
            dataGridViewClass.RowTemplate.Height = 24;
            dataGridViewClass.Size = new Size(1048, 302);
            dataGridViewClass.TabIndex = 0;
            dataGridViewClass.CellContentClick += dataGridViewClass_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 43);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 46);
            label1.TabIndex = 0;
            label1.Text = "Class Management";
            // 
            // EnrollClassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1500, 790);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnrollClassManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnrollClassManagement";
            Load += EnrollClassManagement_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnExamSchedule;
        private System.Windows.Forms.Button btnEnrollClass;
        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtNumberOfStudent;
        private System.Windows.Forms.ComboBox cmbBoxState;
        private System.Windows.Forms.ComboBox cmbClassShift;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.ComboBox cmbTeacherID;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbTimeTable;
        private System.Windows.Forms.Label lblTimeTable;
        private PictureBox pictureBox1;
    }
}