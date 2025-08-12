namespace PL
{
    partial class TeacherInfoUpdate
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
            label3 = new Label();
            idtch = new TextBox();
            name = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            address = new TextBox();
            phone = new TextBox();
            label8 = new Label();
            salary = new TextBox();
            label9 = new Label();
            label10 = new Label();
            slrcoef = new TextBox();
            label11 = new Label();
            status = new ComboBox();
            gender = new ComboBox();
            update = new Button();
            cancel = new Button();
            birth = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 23);
            label1.TabIndex = 0;
            label1.Text = "Update Teacher Information Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 42);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 110);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 2;
            label3.Text = "IDTeacher:";
            // 
            // idtch
            // 
            idtch.BorderStyle = BorderStyle.FixedSingle;
            idtch.Location = new Point(144, 108);
            idtch.Name = "idtch";
            idtch.ReadOnly = true;
            idtch.Size = new Size(220, 31);
            idtch.TabIndex = 3;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Location = new Point(144, 65);
            name.Name = "name";
            name.Size = new Size(569, 31);
            name.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 67);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 4;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 110);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 4;
            label5.Text = "Birthday:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 156);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 4;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 156);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 4;
            label7.Text = "Address:";
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.FixedSingle;
            address.Location = new Point(493, 154);
            address.Name = "address";
            address.Size = new Size(220, 31);
            address.TabIndex = 5;
            // 
            // phone
            // 
            phone.BorderStyle = BorderStyle.FixedSingle;
            phone.Location = new Point(493, 201);
            phone.Name = "phone";
            phone.Size = new Size(220, 31);
            phone.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 203);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 6;
            label8.Text = "Phone:";
            // 
            // salary
            // 
            salary.BorderStyle = BorderStyle.FixedSingle;
            salary.Location = new Point(144, 201);
            salary.Name = "salary";
            salary.Size = new Size(220, 31);
            salary.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 203);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 7;
            label9.Text = "Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(409, 249);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 10;
            label10.Text = "Status:";
            // 
            // slrcoef
            // 
            slrcoef.BorderStyle = BorderStyle.FixedSingle;
            slrcoef.Location = new Point(246, 247);
            slrcoef.Name = "slrcoef";
            slrcoef.Size = new Size(118, 31);
            slrcoef.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 249);
            label11.Name = "label11";
            label11.Size = new Size(186, 23);
            label11.TabIndex = 11;
            label11.Text = "Salary coefficient:";
            // 
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Working", "Stop working" });
            status.Location = new Point(493, 246);
            status.Name = "status";
            status.Size = new Size(220, 31);
            status.TabIndex = 14;
            // 
            // gender
            // 
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(144, 153);
            gender.Name = "gender";
            gender.Size = new Size(220, 31);
            gender.TabIndex = 15;
            // 
            // update
            // 
            update.BackColor = Color.Teal;
            update.FlatStyle = FlatStyle.Flat;
            update.ForeColor = Color.White;
            update.Location = new Point(144, 307);
            update.Name = "update";
            update.Size = new Size(113, 48);
            update.TabIndex = 16;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.Teal;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.ForeColor = Color.White;
            cancel.Location = new Point(493, 307);
            cancel.Name = "cancel";
            cancel.Size = new Size(113, 48);
            cancel.TabIndex = 16;
            cancel.Text = "CANCEL";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // birth
            // 
            birth.Format = DateTimePickerFormat.Short;
            birth.Location = new Point(493, 108);
            birth.Name = "birth";
            birth.Size = new Size(220, 31);
            birth.TabIndex = 17;
            // 
            // TeacherInfoUpdate
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 376);
            Controls.Add(birth);
            Controls.Add(cancel);
            Controls.Add(update);
            Controls.Add(gender);
            Controls.Add(status);
            Controls.Add(label10);
            Controls.Add(slrcoef);
            Controls.Add(label11);
            Controls.Add(phone);
            Controls.Add(label8);
            Controls.Add(salary);
            Controls.Add(label9);
            Controls.Add(address);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(idtch);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeacherInfoUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherInfoUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox idtch;
        private TextBox name;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox address;
        private TextBox phone;
        private Label label8;
        private TextBox salary;
        private Label label9;
        private Label label10;
        private TextBox slrcoef;
        private Label label11;
        private ComboBox status;
        private ComboBox gender;
        private Button update;
        private Button cancel;
        private DateTimePicker birth;
    }
}