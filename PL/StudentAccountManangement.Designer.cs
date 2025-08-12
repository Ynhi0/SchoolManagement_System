namespace PL
{
    partial class StudentAccountManangement
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
            button2 = new Button();
            btnStudentInfor = new Button();
            btnStudentScore = new Button();
            btnReturn = new Button();
            panel2 = new Panel();
            btnAdd = new Button();
            panel5 = new Panel();
            dataGridViewStudentsAccount = new DataGridView();
            panel3 = new Panel();
            panel6 = new Panel();
            lblTotalAccount = new Label();
            label3 = new Label();
            panel7 = new Panel();
            lblHVconHĐ = new Label();
            label5 = new Label();
            panel8 = new Panel();
            lblHVDaKoHĐ = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentsAccount).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(303, 63);
            label2.Name = "label2";
            label2.Size = new Size(334, 41);
            label2.TabIndex = 11;
            label2.Text = "STUDENT'S ACCOUNT";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(button2);
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
            pictureBox1.Location = new Point(73, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(63, 215);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 66);
            button2.TabIndex = 1;
            button2.Text = "Student's Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnStudentInfor
            // 
            btnStudentInfor.BackColor = Color.Teal;
            btnStudentInfor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfor.ForeColor = Color.White;
            btnStudentInfor.Location = new Point(62, 298);
            btnStudentInfor.Margin = new Padding(3, 2, 3, 2);
            btnStudentInfor.Name = "btnStudentInfor";
            btnStudentInfor.Size = new Size(170, 66);
            btnStudentInfor.TabIndex = 2;
            btnStudentInfor.Text = "Student's Information";
            btnStudentInfor.UseVisualStyleBackColor = false;
            btnStudentInfor.Click += button3_Click;
            // 
            // btnStudentScore
            // 
            btnStudentScore.BackColor = Color.Teal;
            btnStudentScore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentScore.ForeColor = Color.White;
            btnStudentScore.Location = new Point(62, 399);
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
            btnReturn.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(365, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 682);
            panel2.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(77, 615);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 66);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridViewStudentsAccount);
            panel5.Location = new Point(51, 254);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(989, 357);
            panel5.TabIndex = 1;
            // 
            // dataGridViewStudentsAccount
            // 
            dataGridViewStudentsAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStudentsAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStudentsAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentsAccount.EnableHeadersVisualStyles = false;
            dataGridViewStudentsAccount.Location = new Point(-1, -1);
            dataGridViewStudentsAccount.Margin = new Padding(3, 2, 3, 2);
            dataGridViewStudentsAccount.Name = "dataGridViewStudentsAccount";
            dataGridViewStudentsAccount.RowHeadersWidth = 51;
            dataGridViewStudentsAccount.RowTemplate.Height = 24;
            dataGridViewStudentsAccount.Size = new Size(989, 357);
            dataGridViewStudentsAccount.TabIndex = 0;
            dataGridViewStudentsAccount.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(51, 28);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(987, 222);
            panel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblTotalAccount);
            panel6.Controls.Add(label3);
            panel6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(58, 12);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 170);
            panel6.TabIndex = 2;
            // 
            // lblTotalAccount
            // 
            lblTotalAccount.AutoSize = true;
            lblTotalAccount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAccount.ForeColor = Color.White;
            lblTotalAccount.Location = new Point(142, 123);
            lblTotalAccount.Name = "lblTotalAccount";
            lblTotalAccount.Size = new Size(38, 46);
            lblTotalAccount.TabIndex = 1;
            lblTotalAccount.Text = "0";
            lblTotalAccount.Click += lblTotalAccount_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 0;
            label3.Text = "Tổng Tài Khoản:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblHVconHĐ);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(386, 10);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 170);
            panel7.TabIndex = 3;
            // 
            // lblHVconHĐ
            // 
            lblHVconHĐ.AutoSize = true;
            lblHVconHĐ.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHVconHĐ.ForeColor = Color.White;
            lblHVconHĐ.Location = new Point(145, 125);
            lblHVconHĐ.Name = "lblHVconHĐ";
            lblHVconHĐ.Size = new Size(38, 46);
            lblHVconHĐ.TabIndex = 3;
            lblHVconHĐ.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 15);
            label5.Name = "label5";
            label5.Size = new Size(159, 60);
            label5.TabIndex = 2;
            label5.Text = "Tài Khoản Còn\r\nHoạt Động";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Teal;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblHVDaKoHĐ);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(726, 9);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 170);
            panel8.TabIndex = 4;
            // 
            // lblHVDaKoHĐ
            // 
            lblHVDaKoHĐ.AutoSize = true;
            lblHVDaKoHĐ.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHVDaKoHĐ.ForeColor = Color.White;
            lblHVDaKoHĐ.Location = new Point(148, 126);
            lblHVDaKoHĐ.Name = "lblHVDaKoHĐ";
            lblHVDaKoHĐ.Size = new Size(38, 46);
            lblHVDaKoHĐ.TabIndex = 3;
            lblHVDaKoHĐ.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(157, 60);
            label7.TabIndex = 2;
            label7.Text = "Tài Khoản Hết\r\nHoạt Động";
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
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(457, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Account Management";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(62, 485);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 66);
            button1.TabIndex = 13;
            button1.Text = "Student's Fee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StudentAccountManangement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 790);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentAccountManangement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentAccountManangement";
            Load += StudentAccountManangement_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentsAccount).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStudentInfor;
        private System.Windows.Forms.Button btnStudentScore;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewStudentsAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblHVconHĐ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblHVDaKoHĐ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button button1;
    }
}