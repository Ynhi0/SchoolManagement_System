namespace PL
{
    partial class SalaryAddForm
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
            label1 = new Label();
            label2 = new Label();
            slradd_ID = new TextBox();
            label3 = new Label();
            slradd_idtch = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            slradd_wrkhrs = new TextBox();
            slradd_add = new Button();
            slradd_cancel = new Button();
            label7 = new Label();
            slradd_year = new TextBox();
            slradd_month = new TextBox();
            slradd_sts = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 0;
            label1.Text = "Salary details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 59);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // slradd_ID
            // 
            slradd_ID.BorderStyle = BorderStyle.FixedSingle;
            slradd_ID.Location = new Point(187, 57);
            slradd_ID.Name = "slradd_ID";
            slradd_ID.Size = new Size(401, 31);
            slradd_ID.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 105);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 1;
            label3.Text = "IdTeacher:";
            // 
            // slradd_idtch
            // 
            slradd_idtch.BorderStyle = BorderStyle.FixedSingle;
            slradd_idtch.Location = new Point(187, 103);
            slradd_idtch.Name = "slradd_idtch";
            slradd_idtch.Size = new Size(401, 31);
            slradd_idtch.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 151);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 1;
            label4.Text = "Month:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 197);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 1;
            label5.Text = "Year:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 247);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 1;
            label6.Text = "Working hours:";
            // 
            // slradd_wrkhrs
            // 
            slradd_wrkhrs.BorderStyle = BorderStyle.FixedSingle;
            slradd_wrkhrs.Location = new Point(187, 245);
            slradd_wrkhrs.Name = "slradd_wrkhrs";
            slradd_wrkhrs.Size = new Size(401, 31);
            slradd_wrkhrs.TabIndex = 4;
            // 
            // slradd_add
            // 
            slradd_add.BackColor = Color.Teal;
            slradd_add.FlatStyle = FlatStyle.Flat;
            slradd_add.ForeColor = Color.White;
            slradd_add.Location = new Point(132, 341);
            slradd_add.Name = "slradd_add";
            slradd_add.Size = new Size(107, 55);
            slradd_add.TabIndex = 6;
            slradd_add.Text = "ADD";
            slradd_add.UseVisualStyleBackColor = false;
            slradd_add.Click += slradd_add_Click;
            // 
            // slradd_cancel
            // 
            slradd_cancel.BackColor = Color.Teal;
            slradd_cancel.FlatStyle = FlatStyle.Flat;
            slradd_cancel.ForeColor = Color.White;
            slradd_cancel.Location = new Point(426, 341);
            slradd_cancel.Name = "slradd_cancel";
            slradd_cancel.Size = new Size(107, 55);
            slradd_cancel.TabIndex = 7;
            slradd_cancel.Text = "CANCEL";
            slradd_cancel.UseVisualStyleBackColor = false;
            slradd_cancel.Click += slradd_cancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 295);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 1;
            label7.Text = "Status:";
            // 
            // slradd_year
            // 
            slradd_year.BorderStyle = BorderStyle.FixedSingle;
            slradd_year.Location = new Point(187, 195);
            slradd_year.Name = "slradd_year";
            slradd_year.Size = new Size(401, 31);
            slradd_year.TabIndex = 3;
            // 
            // slradd_month
            // 
            slradd_month.BorderStyle = BorderStyle.FixedSingle;
            slradd_month.Location = new Point(187, 149);
            slradd_month.Name = "slradd_month";
            slradd_month.Size = new Size(401, 31);
            slradd_month.TabIndex = 2;
            // 
            // slradd_sts
            // 
            slradd_sts.FormattingEnabled = true;
            slradd_sts.Items.AddRange(new object[] { "Solving", "Solved" });
            slradd_sts.Location = new Point(187, 292);
            slradd_sts.Name = "slradd_sts";
            slradd_sts.Size = new Size(401, 31);
            slradd_sts.TabIndex = 5;
            // 
            // SalaryAddForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 420);
            Controls.Add(slradd_sts);
            Controls.Add(slradd_cancel);
            Controls.Add(slradd_add);
            Controls.Add(label7);
            Controls.Add(slradd_wrkhrs);
            Controls.Add(label6);
            Controls.Add(slradd_year);
            Controls.Add(label5);
            Controls.Add(slradd_month);
            Controls.Add(label4);
            Controls.Add(slradd_idtch);
            Controls.Add(label3);
            Controls.Add(slradd_ID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SalaryAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalaryAddForm";
            Load += SalaryAddForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox slradd_ID;
        private Label label3;
        private TextBox slradd_idtch;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox slradd_wrkhrs;
        private Button slradd_add;
        private Button slradd_cancel;
        private Label label7;
        private TextBox slradd_year;
        private TextBox slradd_month;
        private ComboBox slradd_sts;
    }
}