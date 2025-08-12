namespace PL
{
    partial class StudentScoreManagement
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
            btnStudentAccount = new Button();
            btnStudentInfor = new Button();
            btnStudentScore = new Button();
            btnReturn = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            dataGridViewStudentsScore = new DataGridView();
            panel3 = new Panel();
            panel8 = new Panel();
            lblHVDaNghiHoc = new Label();
            label7 = new Label();
            panel7 = new Panel();
            lblFailedStudent = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblTotalPassStudent = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentsScore).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(303, 45);
            label2.Name = "label2";
            label2.Size = new Size(284, 41);
            label2.TabIndex = 11;
            label2.Text = "STUDENT'S SCORE";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnStudentAccount);
            panel4.Controls.Add(btnStudentInfor);
            panel4.Controls.Add(btnStudentScore);
            panel4.Controls.Add(btnReturn);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 43);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 747);
            panel4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(74, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnStudentAccount
            // 
            btnStudentAccount.BackColor = Color.Teal;
            btnStudentAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentAccount.ForeColor = Color.White;
            btnStudentAccount.Location = new Point(62, 241);
            btnStudentAccount.Margin = new Padding(3, 2, 3, 2);
            btnStudentAccount.Name = "btnStudentAccount";
            btnStudentAccount.Size = new Size(170, 66);
            btnStudentAccount.TabIndex = 1;
            btnStudentAccount.Text = "Student's Account";
            btnStudentAccount.UseVisualStyleBackColor = false;
            btnStudentAccount.Click += btnStudentAccount_Click;
            // 
            // btnStudentInfor
            // 
            btnStudentInfor.BackColor = Color.Teal;
            btnStudentInfor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfor.ForeColor = Color.White;
            btnStudentInfor.Location = new Point(62, 325);
            btnStudentInfor.Margin = new Padding(3, 2, 3, 2);
            btnStudentInfor.Name = "btnStudentInfor";
            btnStudentInfor.Size = new Size(170, 66);
            btnStudentInfor.TabIndex = 2;
            btnStudentInfor.Text = "Student's Information";
            btnStudentInfor.UseVisualStyleBackColor = false;
            btnStudentInfor.Click += btnStudentInfor_Click;
            // 
            // btnStudentScore
            // 
            btnStudentScore.BackColor = Color.Teal;
            btnStudentScore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentScore.ForeColor = Color.White;
            btnStudentScore.Location = new Point(62, 414);
            btnStudentScore.Margin = new Padding(3, 2, 3, 2);
            btnStudentScore.Name = "btnStudentScore";
            btnStudentScore.Size = new Size(170, 66);
            btnStudentScore.TabIndex = 3;
            btnStudentScore.Text = "Student's Score";
            btnStudentScore.UseVisualStyleBackColor = false;
            btnStudentScore.Click += btnStudentScore_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Teal;
            btnReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(62, 612);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(170, 66);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(365, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 682);
            panel2.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridViewStudentsScore);
            panel5.Location = new Point(51, 250);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(989, 392);
            panel5.TabIndex = 1;
            // 
            // dataGridViewStudentsScore
            // 
            dataGridViewStudentsScore.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStudentsScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStudentsScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentsScore.EnableHeadersVisualStyles = false;
            dataGridViewStudentsScore.Location = new Point(-1, -1);
            dataGridViewStudentsScore.Margin = new Padding(3, 2, 3, 2);
            dataGridViewStudentsScore.Name = "dataGridViewStudentsScore";
            dataGridViewStudentsScore.RowHeadersWidth = 51;
            dataGridViewStudentsScore.RowTemplate.Height = 24;
            dataGridViewStudentsScore.Size = new Size(989, 389);
            dataGridViewStudentsScore.TabIndex = 0;
            dataGridViewStudentsScore.CellContentClick += dataGridViewStudentsScore_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(51, 28);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(987, 222);
            panel3.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Teal;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblHVDaNghiHoc);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(734, 12);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 170);
            panel8.TabIndex = 9;
            // 
            // lblHVDaNghiHoc
            // 
            lblHVDaNghiHoc.AutoSize = true;
            lblHVDaNghiHoc.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHVDaNghiHoc.ForeColor = Color.White;
            lblHVDaNghiHoc.Location = new Point(157, 123);
            lblHVDaNghiHoc.Name = "lblHVDaNghiHoc";
            lblHVDaNghiHoc.Size = new Size(38, 46);
            lblHVDaNghiHoc.TabIndex = 3;
            lblHVDaNghiHoc.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(124, 60);
            label7.TabIndex = 2;
            label7.Text = "Học Viên\r\nKhông Thi:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblFailedStudent);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(416, 12);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 170);
            panel7.TabIndex = 8;
            // 
            // lblFailedStudent
            // 
            lblFailedStudent.AutoSize = true;
            lblFailedStudent.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFailedStudent.ForeColor = Color.White;
            lblFailedStudent.Location = new Point(157, 123);
            lblFailedStudent.Name = "lblFailedStudent";
            lblFailedStudent.Size = new Size(38, 46);
            lblFailedStudent.TabIndex = 3;
            lblFailedStudent.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(179, 60);
            label5.TabIndex = 2;
            label5.Text = "Học Viên Không\r\nĐạt:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblTotalPassStudent);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(49, 12);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 170);
            panel6.TabIndex = 7;
            // 
            // lblTotalPassStudent
            // 
            lblTotalPassStudent.AutoSize = true;
            lblTotalPassStudent.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPassStudent.ForeColor = Color.White;
            lblTotalPassStudent.Location = new Point(146, 123);
            lblTotalPassStudent.Name = "lblTotalPassStudent";
            lblTotalPassStudent.Size = new Size(38, 46);
            lblTotalPassStudent.TabIndex = 1;
            lblTotalPassStudent.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(165, 60);
            label3.TabIndex = 0;
            label3.Text = "Tổng Học Viên\r\n Đạt:";
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
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 2);
            label1.Name = "label1";
            label1.Size = new Size(313, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Mangement";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(62, 494);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 66);
            button1.TabIndex = 14;
            button1.Text = "Student's Fee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StudentScoreManagement
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentScoreManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentScoreManagement";
            Load += StudentScoreManagement_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentsScore).EndInit();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStudentAccount;
        private System.Windows.Forms.Button btnStudentInfor;
        private System.Windows.Forms.Button btnStudentScore;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewStudentsScore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblHVDaNghiHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblFailedStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalPassStudent;
        private System.Windows.Forms.Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}