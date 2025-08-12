namespace PL
{
    partial class InfoUpdate
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
            info_cancel = new Button();
            info_save = new Button();
            info_role = new ComboBox();
            label5 = new Label();
            info_displ = new TextBox();
            label4 = new Label();
            info_pass = new TextBox();
            label3 = new Label();
            info_user = new TextBox();
            label2 = new Label();
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
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 1;
            label1.Text = "Information Update";
            // 
            // info_cancel
            // 
            info_cancel.BackColor = Color.Teal;
            info_cancel.FlatStyle = FlatStyle.Flat;
            info_cancel.ForeColor = Color.White;
            info_cancel.Location = new Point(203, 398);
            info_cancel.Name = "info_cancel";
            info_cancel.Size = new Size(104, 46);
            info_cancel.TabIndex = 5;
            info_cancel.Text = "Cancel";
            info_cancel.UseVisualStyleBackColor = false;
            info_cancel.Click += info_cancel_Click;
            // 
            // info_save
            // 
            info_save.BackColor = Color.Teal;
            info_save.FlatStyle = FlatStyle.Flat;
            info_save.ForeColor = Color.White;
            info_save.Location = new Point(37, 398);
            info_save.Name = "info_save";
            info_save.Size = new Size(104, 46);
            info_save.TabIndex = 4;
            info_save.Text = "Save";
            info_save.UseVisualStyleBackColor = false;
            info_save.Click += info_save_Click;
            // 
            // info_role
            // 
            info_role.DropDownStyle = ComboBoxStyle.DropDownList;
            info_role.FormattingEnabled = true;
            info_role.Items.AddRange(new object[] { "Teacher", "Student" });
            info_role.Location = new Point(66, 338);
            info_role.Name = "info_role";
            info_role.Size = new Size(241, 31);
            info_role.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(37, 312);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 6;
            label5.Text = "Role:";
            // 
            // info_displ
            // 
            info_displ.BorderStyle = BorderStyle.FixedSingle;
            info_displ.Location = new Point(66, 252);
            info_displ.Name = "info_displ";
            info_displ.Size = new Size(241, 31);
            info_displ.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(37, 226);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 7;
            label4.Text = "Display name:";
            // 
            // info_pass
            // 
            info_pass.BorderStyle = BorderStyle.FixedSingle;
            info_pass.Location = new Point(66, 173);
            info_pass.Name = "info_pass";
            info_pass.PasswordChar = '*';
            info_pass.Size = new Size(241, 31);
            info_pass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(37, 147);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // info_user
            // 
            info_user.BorderStyle = BorderStyle.FixedSingle;
            info_user.Location = new Point(66, 97);
            info_user.Name = "info_user";
            info_user.Size = new Size(241, 31);
            info_user.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(37, 71);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // InfoUpdate
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 473);
            Controls.Add(panel1);
            Controls.Add(info_cancel);
            Controls.Add(info_save);
            Controls.Add(info_role);
            Controls.Add(label5);
            Controls.Add(info_displ);
            Controls.Add(label4);
            Controls.Add(info_pass);
            Controls.Add(label3);
            Controls.Add(info_user);
            Controls.Add(label2);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "InfoUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoUpdate";
            Load += InfoUpdate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button info_cancel;
        private Button info_save;
        private ComboBox info_role;
        private Label label5;
        private TextBox info_displ;
        private Label label4;
        private TextBox info_pass;
        private Label label3;
        private TextBox info_user;
        private Label label2;
    }
}