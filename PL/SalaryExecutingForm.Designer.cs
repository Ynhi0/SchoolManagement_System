namespace PL
{
    partial class SalaryExecutingForm
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
            exe_idtch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            exe_month = new ComboBox();
            exe_year = new ComboBox();
            exe_execute = new Button();
            exe_cancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 0;
            label1.Text = "Salary Execution";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 77);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 1;
            label2.Text = "IDTeacher:";
            // 
            // exe_idtch
            // 
            exe_idtch.BorderStyle = BorderStyle.FixedSingle;
            exe_idtch.Location = new Point(190, 75);
            exe_idtch.Name = "exe_idtch";
            exe_idtch.Size = new Size(210, 31);
            exe_idtch.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 152);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 3;
            label3.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 115);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 5;
            label4.Text = "Month:";
            // 
            // exe_month
            // 
            exe_month.DropDownStyle = ComboBoxStyle.DropDownList;
            exe_month.FormattingEnabled = true;
            exe_month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            exe_month.Location = new Point(190, 112);
            exe_month.Name = "exe_month";
            exe_month.Size = new Size(210, 31);
            exe_month.TabIndex = 1;
            // 
            // exe_year
            // 
            exe_year.DropDownStyle = ComboBoxStyle.DropDownList;
            exe_year.FormattingEnabled = true;
            exe_year.Items.AddRange(new object[] { "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            exe_year.Location = new Point(190, 149);
            exe_year.Name = "exe_year";
            exe_year.Size = new Size(210, 31);
            exe_year.TabIndex = 2;
            // 
            // exe_execute
            // 
            exe_execute.BackColor = Color.Teal;
            exe_execute.FlatStyle = FlatStyle.Flat;
            exe_execute.ForeColor = Color.White;
            exe_execute.Location = new Point(65, 201);
            exe_execute.Name = "exe_execute";
            exe_execute.Size = new Size(119, 47);
            exe_execute.TabIndex = 3;
            exe_execute.Text = "EXECUTE";
            exe_execute.UseVisualStyleBackColor = false;
            exe_execute.Click += exe_execute_Click;
            // 
            // exe_cancel
            // 
            exe_cancel.BackColor = Color.Teal;
            exe_cancel.FlatStyle = FlatStyle.Flat;
            exe_cancel.ForeColor = Color.White;
            exe_cancel.Location = new Point(281, 201);
            exe_cancel.Name = "exe_cancel";
            exe_cancel.Size = new Size(119, 47);
            exe_cancel.TabIndex = 7;
            exe_cancel.Text = "CANCEL";
            exe_cancel.UseVisualStyleBackColor = false;
            exe_cancel.Click += exe_cancel_Click;
            // 
            // SalaryExecutingForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 274);
            Controls.Add(exe_cancel);
            Controls.Add(exe_execute);
            Controls.Add(exe_year);
            Controls.Add(exe_month);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(exe_idtch);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SalaryExecutingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalaryExecutingForm";
            Load += SalaryExecutingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox exe_idtch;
        private Label label3;
        private Label label4;
        private ComboBox exe_month;
        private ComboBox exe_year;
        private Button exe_execute;
        private Button exe_cancel;
    }
}