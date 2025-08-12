namespace PL
{
    partial class TeacherForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            salary_tch = new Panel();
            tchslr_year = new ComboBox();
            label9 = new Label();
            tchslr_month = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tchslr_search = new TextBox();
            tchslr_exc = new Button();
            tchslr_add = new Button();
            tchslr_slrif = new DataGridView();
            panel2 = new Panel();
            salary = new Button();
            tch_info = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tch_return = new Button();
            info_tch = new Panel();
            tch_add = new Button();
            label6 = new Label();
            tchinfo_working = new TextBox();
            tchinfo_total = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tch_search = new TextBox();
            TeacherInfo = new DataGridView();
            panel1.SuspendLayout();
            salary_tch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tchslr_slrif).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            info_tch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 43);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 0;
            label1.Text = "Teacher ";
            // 
            // salary_tch
            // 
            salary_tch.Controls.Add(tchslr_year);
            salary_tch.Controls.Add(label9);
            salary_tch.Controls.Add(tchslr_month);
            salary_tch.Controls.Add(label8);
            salary_tch.Controls.Add(label7);
            salary_tch.Controls.Add(tchslr_search);
            salary_tch.Controls.Add(tchslr_exc);
            salary_tch.Controls.Add(tchslr_add);
            salary_tch.Controls.Add(tchslr_slrif);
            salary_tch.Location = new Point(278, 20);
            salary_tch.Name = "salary_tch";
            salary_tch.Size = new Size(1201, 747);
            salary_tch.TabIndex = 68;
            // 
            // tchslr_year
            // 
            tchslr_year.FormattingEnabled = true;
            tchslr_year.Items.AddRange(new object[] { "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            tchslr_year.Location = new Point(292, 42);
            tchslr_year.Name = "tchslr_year";
            tchslr_year.Size = new Size(134, 31);
            tchslr_year.TabIndex = 1;
            tchslr_year.TextChanged += tchslr_year_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(224, 45);
            label9.Name = "label9";
            label9.Size = new Size(62, 23);
            label9.TabIndex = 77;
            label9.Text = "Year:";
            // 
            // tchslr_month
            // 
            tchslr_month.FormattingEnabled = true;
            tchslr_month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            tchslr_month.Location = new Point(116, 42);
            tchslr_month.Name = "tchslr_month";
            tchslr_month.Size = new Size(74, 31);
            tchslr_month.TabIndex = 0;
            tchslr_month.SelectedIndexChanged += tchslr_month_SelectedIndexChanged;
            tchslr_month.TextChanged += tchslr_month_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 45);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 78;
            label8.Text = "Month:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 45);
            label7.Name = "label7";
            label7.Size = new Size(37, 23);
            label7.TabIndex = 79;
            label7.Text = "ID:";
            // 
            // tchslr_search
            // 
            tchslr_search.BorderStyle = BorderStyle.FixedSingle;
            tchslr_search.Location = new Point(516, 43);
            tchslr_search.Name = "tchslr_search";
            tchslr_search.Size = new Size(196, 31);
            tchslr_search.TabIndex = 2;
            tchslr_search.TextChanged += tchslr_search_TextChanged;
            // 
            // tchslr_exc
            // 
            tchslr_exc.BackColor = Color.Teal;
            tchslr_exc.FlatStyle = FlatStyle.Flat;
            tchslr_exc.ForeColor = Color.White;
            tchslr_exc.Location = new Point(244, 670);
            tchslr_exc.Name = "tchslr_exc";
            tchslr_exc.Size = new Size(134, 53);
            tchslr_exc.TabIndex = 4;
            tchslr_exc.Text = "EXECUTE";
            tchslr_exc.UseVisualStyleBackColor = false;
            tchslr_exc.Click += tchslr_exc_Click;
            // 
            // tchslr_add
            // 
            tchslr_add.BackColor = Color.Teal;
            tchslr_add.FlatStyle = FlatStyle.Flat;
            tchslr_add.ForeColor = Color.White;
            tchslr_add.Location = new Point(56, 670);
            tchslr_add.Name = "tchslr_add";
            tchslr_add.Size = new Size(134, 53);
            tchslr_add.TabIndex = 3;
            tchslr_add.Text = "ADD";
            tchslr_add.UseVisualStyleBackColor = false;
            tchslr_add.Click += tchslr_add_Click;
            // 
            // tchslr_slrif
            // 
            tchslr_slrif.AllowUserToAddRows = false;
            tchslr_slrif.AllowUserToDeleteRows = false;
            tchslr_slrif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tchslr_slrif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tchslr_slrif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tchslr_slrif.EnableHeadersVisualStyles = false;
            tchslr_slrif.Location = new Point(34, 80);
            tchslr_slrif.Name = "tchslr_slrif";
            tchslr_slrif.ReadOnly = true;
            tchslr_slrif.RowHeadersVisible = false;
            tchslr_slrif.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tchslr_slrif.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tchslr_slrif.Size = new Size(1134, 571);
            tchslr_slrif.TabIndex = 72;
            tchslr_slrif.CellContentClick += tchslr_slrif_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(salary);
            panel2.Controls.Add(tch_info);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(tch_return);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 747);
            panel2.TabIndex = 2;
            // 
            // salary
            // 
            salary.FlatStyle = FlatStyle.Flat;
            salary.ForeColor = Color.White;
            salary.Location = new Point(62, 340);
            salary.Name = "salary";
            salary.Size = new Size(170, 53);
            salary.TabIndex = 6;
            salary.Text = "SALARY";
            salary.UseVisualStyleBackColor = true;
            salary.Click += salary_Click;
            // 
            // tch_info
            // 
            tch_info.FlatStyle = FlatStyle.Flat;
            tch_info.ForeColor = Color.White;
            tch_info.Location = new Point(62, 264);
            tch_info.Name = "tch_info";
            tch_info.Size = new Size(170, 53);
            tch_info.TabIndex = 1;
            tch_info.Text = "INFORMATION";
            tch_info.UseVisualStyleBackColor = true;
            tch_info.Click += tch_info_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(98, 207);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 4;
            label3.Text = "SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 184);
            label2.Name = "label2";
            label2.Size = new Size(249, 23);
            label2.TabIndex = 5;
            label2.Text = "SCHOOL MANAGEMENT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(85, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tch_return
            // 
            tch_return.BackColor = Color.Teal;
            tch_return.FlatStyle = FlatStyle.Flat;
            tch_return.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tch_return.ForeColor = Color.White;
            tch_return.Location = new Point(62, 670);
            tch_return.Name = "tch_return";
            tch_return.Size = new Size(170, 53);
            tch_return.TabIndex = 0;
            tch_return.Text = "RETURN";
            tch_return.UseVisualStyleBackColor = false;
            tch_return.Click += tch_return_Click;
            // 
            // info_tch
            // 
            info_tch.BackColor = Color.White;
            info_tch.Controls.Add(salary_tch);
            info_tch.Controls.Add(tch_add);
            info_tch.Controls.Add(label6);
            info_tch.Controls.Add(tchinfo_working);
            info_tch.Controls.Add(tchinfo_total);
            info_tch.Controls.Add(label5);
            info_tch.Controls.Add(label4);
            info_tch.Controls.Add(tch_search);
            info_tch.Controls.Add(TeacherInfo);
            info_tch.Location = new Point(299, 43);
            info_tch.Name = "info_tch";
            info_tch.Size = new Size(1201, 747);
            info_tch.TabIndex = 3;
            // 
            // tch_add
            // 
            tch_add.BackColor = Color.Teal;
            tch_add.FlatStyle = FlatStyle.Flat;
            tch_add.ForeColor = Color.White;
            tch_add.Location = new Point(86, 670);
            tch_add.Name = "tch_add";
            tch_add.Size = new Size(134, 53);
            tch_add.TabIndex = 51;
            tch_add.Text = "ADD";
            tch_add.UseVisualStyleBackColor = false;
            tch_add.Click += tch_add_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(197, 66);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 65;
            label6.Text = "Working:";
            // 
            // tchinfo_working
            // 
            tchinfo_working.BorderStyle = BorderStyle.FixedSingle;
            tchinfo_working.Location = new Point(291, 63);
            tchinfo_working.Name = "tchinfo_working";
            tchinfo_working.Size = new Size(74, 31);
            tchinfo_working.TabIndex = 67;
            // 
            // tchinfo_total
            // 
            tchinfo_total.BackColor = Color.White;
            tchinfo_total.BorderStyle = BorderStyle.FixedSingle;
            tchinfo_total.Location = new Point(96, 63);
            tchinfo_total.Name = "tchinfo_total";
            tchinfo_total.Size = new Size(74, 31);
            tchinfo_total.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 66);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 66;
            label5.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(823, 63);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 64;
            label4.Text = "Search:";
            // 
            // tch_search
            // 
            tch_search.BorderStyle = BorderStyle.FixedSingle;
            tch_search.Location = new Point(915, 61);
            tch_search.Name = "tch_search";
            tch_search.Size = new Size(258, 31);
            tch_search.TabIndex = 63;
            tch_search.TextChanged += tch_search_TextChanged;
            // 
            // TeacherInfo
            // 
            TeacherInfo.AllowUserToAddRows = false;
            TeacherInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            TeacherInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            TeacherInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeacherInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Teal;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TeacherInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TeacherInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherInfo.EnableHeadersVisualStyles = false;
            TeacherInfo.Location = new Point(30, 105);
            TeacherInfo.Name = "TeacherInfo";
            TeacherInfo.ReadOnly = true;
            TeacherInfo.RowHeadersVisible = false;
            TeacherInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            TeacherInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            TeacherInfo.Size = new Size(1143, 546);
            TeacherInfo.TabIndex = 62;
            TeacherInfo.CellContentClick += TeacherInfo_CellContentClick;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(info_tch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            salary_tch.ResumeLayout(false);
            salary_tch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tchslr_slrif).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            info_tch.ResumeLayout(false);
            info_tch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button tch_return;
        private Label label3;
        private Label label2;
        private Button tch_info;
        private Button salary;
        private Panel info_tch;
        private Button tch_add;
        private Label label6;
        private TextBox tchinfo_working;
        private TextBox tchinfo_total;
        private Label label5;
        private Label label4;
        private TextBox tch_search;
        private DataGridView TeacherInfo;
        private Panel salary_tch;
        private ComboBox tchslr_year;
        private Label label9;
        private ComboBox tchslr_month;
        private Label label8;
        private Label label7;
        private TextBox tchslr_search;
        private Button tchslr_exc;
        private Button tchslr_add;
        private DataGridView tchslr_slrif;
    }
}