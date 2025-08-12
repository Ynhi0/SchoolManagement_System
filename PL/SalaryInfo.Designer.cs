namespace PL
{
    partial class SalaryInfo
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            slrupd_id = new TextBox();
            label3 = new Label();
            slrupd_idtch = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            slrupd_wrkhrs = new TextBox();
            label7 = new Label();
            slrupd_save = new Button();
            slrupd_cancel = new Button();
            slrupd_sts = new ComboBox();
            slrupd_month = new ComboBox();
            slrupd_year = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 23);
            label1.TabIndex = 0;
            label1.Text = "Salary Details Update";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 40);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 66);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // slrupd_id
            // 
            slrupd_id.BorderStyle = BorderStyle.FixedSingle;
            slrupd_id.Location = new Point(191, 64);
            slrupd_id.Name = "slrupd_id";
            slrupd_id.ReadOnly = true;
            slrupd_id.Size = new Size(182, 31);
            slrupd_id.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 103);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 2;
            label3.Text = "IDTeacher:";
            // 
            // slrupd_idtch
            // 
            slrupd_idtch.BorderStyle = BorderStyle.FixedSingle;
            slrupd_idtch.Location = new Point(191, 101);
            slrupd_idtch.Name = "slrupd_idtch";
            slrupd_idtch.Size = new Size(182, 31);
            slrupd_idtch.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 140);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 2;
            label4.Text = "Month:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 177);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 2;
            label5.Text = "Year:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 214);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 2;
            label6.Text = "Working hours:";
            // 
            // slrupd_wrkhrs
            // 
            slrupd_wrkhrs.BorderStyle = BorderStyle.FixedSingle;
            slrupd_wrkhrs.Location = new Point(191, 212);
            slrupd_wrkhrs.Name = "slrupd_wrkhrs";
            slrupd_wrkhrs.Size = new Size(182, 31);
            slrupd_wrkhrs.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 251);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 2;
            label7.Text = "Status:";
            // 
            // slrupd_save
            // 
            slrupd_save.BackColor = Color.Teal;
            slrupd_save.FlatStyle = FlatStyle.Flat;
            slrupd_save.ForeColor = Color.White;
            slrupd_save.Location = new Point(41, 312);
            slrupd_save.Name = "slrupd_save";
            slrupd_save.Size = new Size(115, 47);
            slrupd_save.TabIndex = 6;
            slrupd_save.Text = "SAVE";
            slrupd_save.UseVisualStyleBackColor = false;
            slrupd_save.Click += slrupd_save_Click;
            // 
            // slrupd_cancel
            // 
            slrupd_cancel.BackColor = Color.Teal;
            slrupd_cancel.FlatStyle = FlatStyle.Flat;
            slrupd_cancel.ForeColor = Color.White;
            slrupd_cancel.Location = new Point(258, 312);
            slrupd_cancel.Name = "slrupd_cancel";
            slrupd_cancel.Size = new Size(115, 47);
            slrupd_cancel.TabIndex = 7;
            slrupd_cancel.Text = "CANCEL";
            slrupd_cancel.UseVisualStyleBackColor = false;
            slrupd_cancel.Click += slrupd_cancel_Click;
            // 
            // slrupd_sts
            // 
            slrupd_sts.FormattingEnabled = true;
            slrupd_sts.Items.AddRange(new object[] { "Solving", "Solved" });
            slrupd_sts.Location = new Point(191, 249);
            slrupd_sts.Name = "slrupd_sts";
            slrupd_sts.Size = new Size(182, 31);
            slrupd_sts.TabIndex = 5;
            // 
            // slrupd_month
            // 
            slrupd_month.FormattingEnabled = true;
            slrupd_month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            slrupd_month.Location = new Point(191, 137);
            slrupd_month.Name = "slrupd_month";
            slrupd_month.Size = new Size(182, 31);
            slrupd_month.TabIndex = 2;
            // 
            // slrupd_year
            // 
            slrupd_year.FormattingEnabled = true;
            slrupd_year.Items.AddRange(new object[] { "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            slrupd_year.Location = new Point(191, 174);
            slrupd_year.Name = "slrupd_year";
            slrupd_year.Size = new Size(182, 31);
            slrupd_year.TabIndex = 3;
            // 
            // SalaryInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 371);
            Controls.Add(slrupd_year);
            Controls.Add(slrupd_month);
            Controls.Add(slrupd_sts);
            Controls.Add(slrupd_cancel);
            Controls.Add(slrupd_save);
            Controls.Add(label7);
            Controls.Add(slrupd_wrkhrs);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(slrupd_idtch);
            Controls.Add(label3);
            Controls.Add(slrupd_id);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SalaryInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalaryInfo";
            Load += SalaryInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox slrupd_id;
        private Label label3;
        private TextBox slrupd_idtch;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox slrupd_wrkhrs;
        private Label label7;
        private Button slrupd_save;
        private Button slrupd_cancel;
        private ComboBox slrupd_sts;
        private ComboBox slrupd_month;
        private ComboBox slrupd_year;
    }
}