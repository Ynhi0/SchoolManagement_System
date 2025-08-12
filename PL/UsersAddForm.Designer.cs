namespace PL
{
    partial class UsersAddForm
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
            useradd_user = new TextBox();
            label3 = new Label();
            useradd_pass = new TextBox();
            label4 = new Label();
            useradd_dis = new TextBox();
            label5 = new Label();
            useradd_role = new ComboBox();
            useradd_save = new Button();
            useradd_cancel = new Button();
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
            panel1.Size = new Size(353, 39);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 1;
            label1.Text = "Users Add Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // useradd_user
            // 
            useradd_user.BorderStyle = BorderStyle.FixedSingle;
            useradd_user.Location = new Point(64, 99);
            useradd_user.Name = "useradd_user";
            useradd_user.Size = new Size(241, 31);
            useradd_user.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // useradd_pass
            // 
            useradd_pass.BorderStyle = BorderStyle.FixedSingle;
            useradd_pass.Location = new Point(64, 175);
            useradd_pass.Name = "useradd_pass";
            useradd_pass.PasswordChar = '*';
            useradd_pass.Size = new Size(241, 31);
            useradd_pass.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(35, 228);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 1;
            label4.Text = "Display name:";
            // 
            // useradd_dis
            // 
            useradd_dis.BorderStyle = BorderStyle.FixedSingle;
            useradd_dis.Location = new Point(64, 254);
            useradd_dis.Name = "useradd_dis";
            useradd_dis.Size = new Size(241, 31);
            useradd_dis.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(35, 314);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 1;
            label5.Text = "Role:";
            // 
            // useradd_role
            // 
            useradd_role.DropDownStyle = ComboBoxStyle.DropDownList;
            useradd_role.FormattingEnabled = true;
            useradd_role.Items.AddRange(new object[] { "Teacher" });
            useradd_role.Location = new Point(64, 340);
            useradd_role.Name = "useradd_role";
            useradd_role.Size = new Size(241, 31);
            useradd_role.TabIndex = 4;
            // 
            // useradd_save
            // 
            useradd_save.BackColor = Color.Teal;
            useradd_save.FlatStyle = FlatStyle.Flat;
            useradd_save.ForeColor = Color.White;
            useradd_save.Location = new Point(35, 400);
            useradd_save.Name = "useradd_save";
            useradd_save.Size = new Size(104, 46);
            useradd_save.TabIndex = 5;
            useradd_save.Text = "Save";
            useradd_save.UseVisualStyleBackColor = false;
            useradd_save.Click += useradd_save_Click;
            // 
            // useradd_cancel
            // 
            useradd_cancel.BackColor = Color.Teal;
            useradd_cancel.FlatStyle = FlatStyle.Flat;
            useradd_cancel.ForeColor = Color.White;
            useradd_cancel.Location = new Point(201, 400);
            useradd_cancel.Name = "useradd_cancel";
            useradd_cancel.Size = new Size(104, 46);
            useradd_cancel.TabIndex = 6;
            useradd_cancel.Text = "Cancel";
            useradd_cancel.UseVisualStyleBackColor = false;
            useradd_cancel.Click += useradd_cancel_Click;
            // 
            // UsersAddForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 473);
            Controls.Add(useradd_cancel);
            Controls.Add(useradd_save);
            Controls.Add(useradd_role);
            Controls.Add(label5);
            Controls.Add(useradd_dis);
            Controls.Add(label4);
            Controls.Add(useradd_pass);
            Controls.Add(label3);
            Controls.Add(useradd_user);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UsersAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersAddForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox useradd_user;
        private Label label3;
        private TextBox useradd_pass;
        private Label label4;
        private TextBox useradd_dis;
        private Label label5;
        private ComboBox useradd_role;
        private Button useradd_save;
        private Button useradd_cancel;
    }
}