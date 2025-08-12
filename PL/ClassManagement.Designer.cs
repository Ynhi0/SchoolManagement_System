namespace PL
{
    partial class ClassManagement
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
            btnExamSchedule = new Button();
            btnEnrollClass = new Button();
            btnTimeTable = new Button();
            button7 = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            dataGridViewClass = new DataGridView();
            panel3 = new Panel();
            panel6 = new Panel();
            lblTotalClass = new Label();
            label3 = new Label();
            panel7 = new Panel();
            lblOnlClass = new Label();
            label5 = new Label();
            panel8 = new Panel();
            lblOffClass = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
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
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(303, 45);
            label2.Name = "label2";
            label2.Size = new Size(223, 41);
            label2.TabIndex = 15;
            label2.Text = "LIST OF CLASS";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(btnExamSchedule);
            panel4.Controls.Add(btnEnrollClass);
            panel4.Controls.Add(btnTimeTable);
            panel4.Controls.Add(button7);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 43);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 747);
            panel4.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(67, 38);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(62, 241);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 66);
            button2.TabIndex = 1;
            button2.Text = "Class";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnExamSchedule
            // 
            btnExamSchedule.BackColor = Color.Teal;
            btnExamSchedule.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExamSchedule.ForeColor = Color.White;
            btnExamSchedule.Location = new Point(62, 496);
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
            btnEnrollClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollClass.ForeColor = Color.White;
            btnEnrollClass.Location = new Point(62, 325);
            btnEnrollClass.Margin = new Padding(3, 2, 3, 2);
            btnEnrollClass.Name = "btnEnrollClass";
            btnEnrollClass.Size = new Size(170, 66);
            btnEnrollClass.TabIndex = 2;
            btnEnrollClass.Text = "Enroll Class";
            btnEnrollClass.UseVisualStyleBackColor = false;
            btnEnrollClass.Click += btnEnrollClass_Click;
            // 
            // btnTimeTable
            // 
            btnTimeTable.BackColor = Color.Teal;
            btnTimeTable.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeTable.ForeColor = Color.White;
            btnTimeTable.Location = new Point(62, 414);
            btnTimeTable.Margin = new Padding(3, 2, 3, 2);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Size = new Size(170, 66);
            btnTimeTable.TabIndex = 3;
            btnTimeTable.Text = "TimeTable";
            btnTimeTable.UseVisualStyleBackColor = false;
            btnTimeTable.Click += btnTimeTable_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(62, 612);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(170, 66);
            button7.TabIndex = 6;
            button7.Text = "Return";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            panel2.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridViewClass);
            panel5.Location = new Point(51, 250);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(989, 392);
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
            dataGridViewClass.Size = new Size(989, 392);
            dataGridViewClass.TabIndex = 0;
            dataGridViewClass.CellContentClick += dataGridViewClass_CellContentClick;
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
            panel3.Size = new Size(989, 212);
            panel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblTotalClass);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(48, 12);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 170);
            panel6.TabIndex = 2;
            // 
            // lblTotalClass
            // 
            lblTotalClass.AutoSize = true;
            lblTotalClass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalClass.ForeColor = Color.White;
            lblTotalClass.Location = new Point(144, 123);
            lblTotalClass.Name = "lblTotalClass";
            lblTotalClass.Size = new Size(38, 46);
            lblTotalClass.TabIndex = 1;
            lblTotalClass.Text = "0";
            lblTotalClass.Click += lblTotalClass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 0;
            label3.Text = "Tổng Lớp Học:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblOnlClass);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(383, 12);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 170);
            panel7.TabIndex = 3;
            // 
            // lblOnlClass
            // 
            lblOnlClass.AutoSize = true;
            lblOnlClass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOnlClass.ForeColor = Color.White;
            lblOnlClass.Location = new Point(142, 123);
            lblOnlClass.Name = "lblOnlClass";
            lblOnlClass.Size = new Size(38, 46);
            lblOnlClass.TabIndex = 3;
            lblOnlClass.Text = "0";
            lblOnlClass.Click += lblOnlClass_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 15);
            label5.Name = "label5";
            label5.Size = new Size(145, 60);
            label5.TabIndex = 2;
            label5.Text = "Lớp Học Còn\r\nHoạt Động";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Teal;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblOffClass);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(739, 12);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 170);
            panel8.TabIndex = 4;
            // 
            // lblOffClass
            // 
            lblOffClass.AutoSize = true;
            lblOffClass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOffClass.ForeColor = Color.White;
            lblOffClass.Location = new Point(142, 123);
            lblOffClass.Name = "lblOffClass";
            lblOffClass.Size = new Size(38, 46);
            lblOffClass.TabIndex = 3;
            lblOffClass.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(144, 60);
            label7.TabIndex = 2;
            label7.Text = "Lớp Học \r\nĐã Kết Thúc:";
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
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 2);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 0;
            label1.Text = "Class Management";
            // 
            // ClassManagement
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
            Name = "ClassManagement";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassManagement";
            Load += ClassManagement_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
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
        private System.Windows.Forms.Button btnExamSchedule;
        private System.Windows.Forms.Button btnEnrollClass;
        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblOnlClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblOffClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}