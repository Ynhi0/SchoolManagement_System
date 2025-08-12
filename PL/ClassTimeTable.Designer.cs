namespace PL
{
    partial class ClassTimeTable
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
            label2 = new Label();
            panel4 = new Panel();
            btnClass = new Button();
            btnExamSchedule = new Button();
            btnEnrollClass = new Button();
            btnTimeTable = new Button();
            btnReturn = new Button();
            panel2 = new Panel();
            dataGridViewTimeTable = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimeTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(301, 43);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 23;
            label2.Text = "TIMETABLE";
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
            panel4.Size = new Size(295, 747);
            panel4.TabIndex = 22;
            // 
            // btnClass
            // 
            btnClass.BackColor = Color.Teal;
            btnClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnExamSchedule.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExamSchedule.ForeColor = Color.White;
            btnExamSchedule.Location = new Point(62, 519);
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
            btnEnrollClass.Location = new Point(62, 336);
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
            btnTimeTable.Location = new Point(62, 427);
            btnTimeTable.Margin = new Padding(3, 2, 3, 2);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Size = new Size(170, 66);
            btnTimeTable.TabIndex = 3;
            btnTimeTable.Text = "TimeTable";
            btnTimeTable.UseVisualStyleBackColor = false;
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
            panel2.Controls.Add(dataGridViewTimeTable);
            panel2.Location = new Point(365, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 682);
            panel2.TabIndex = 21;
            // 
            // dataGridViewTimeTable
            // 
            dataGridViewTimeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimeTable.Location = new Point(3, 4);
            dataGridViewTimeTable.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTimeTable.Name = "dataGridViewTimeTable";
            dataGridViewTimeTable.RowHeadersWidth = 51;
            dataGridViewTimeTable.RowTemplate.Height = 24;
            dataGridViewTimeTable.Size = new Size(1048, 742);
            dataGridViewTimeTable.TabIndex = 1;
            dataGridViewTimeTable.CellContentClick += dataGridViewTimeTable_CellContentClick;
            dataGridViewTimeTable.RowsAdded += dataGridViewSchedule_RowsAdded;
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
            panel1.TabIndex = 20;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(78, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ClassTimeTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClassTimeTable";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClassTimeTable";
            Load += ClassTimeTable_Load;
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimeTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridViewTimeTable_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            throw new System.NotImplementedException();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTimeTable;
        private PictureBox pictureBox1;
    }
}