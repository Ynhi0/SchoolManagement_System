namespace PL
{
    partial class Admin
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
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ad_logout = new Button();
            admin_class = new Button();
            admin_student = new Button();
            admin_teacher = new Button();
            admin_users = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 43);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1451, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 37);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(285, 23);
            label1.TabIndex = 0;
            label1.Text = "School Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(ad_logout);
            panel2.Controls.Add(admin_class);
            panel2.Controls.Add(admin_student);
            panel2.Controls.Add(admin_teacher);
            panel2.Controls.Add(admin_users);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 747);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(79, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ad_logout
            // 
            ad_logout.BackColor = Color.Teal;
            ad_logout.FlatStyle = FlatStyle.Flat;
            ad_logout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ad_logout.ForeColor = Color.White;
            ad_logout.Location = new Point(62, 648);
            ad_logout.Name = "ad_logout";
            ad_logout.Size = new Size(170, 53);
            ad_logout.TabIndex = 0;
            ad_logout.Text = "LOG OUT";
            ad_logout.UseVisualStyleBackColor = false;
            ad_logout.Click += button4_Click;
            // 
            // admin_class
            // 
            admin_class.BackColor = Color.Teal;
            admin_class.FlatStyle = FlatStyle.Flat;
            admin_class.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_class.ForeColor = Color.White;
            admin_class.Location = new Point(62, 447);
            admin_class.Name = "admin_class";
            admin_class.Size = new Size(170, 53);
            admin_class.TabIndex = 0;
            admin_class.Text = "CLASS";
            admin_class.UseVisualStyleBackColor = false;
            admin_class.Click += admin_class_Click;
            // 
            // admin_student
            // 
            admin_student.BackColor = Color.Teal;
            admin_student.FlatStyle = FlatStyle.Flat;
            admin_student.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_student.ForeColor = Color.White;
            admin_student.Location = new Point(62, 378);
            admin_student.Name = "admin_student";
            admin_student.Size = new Size(170, 53);
            admin_student.TabIndex = 0;
            admin_student.Text = "STUDENT";
            admin_student.UseVisualStyleBackColor = false;
            admin_student.Click += admin_student_Click;
            // 
            // admin_teacher
            // 
            admin_teacher.BackColor = Color.Teal;
            admin_teacher.FlatStyle = FlatStyle.Flat;
            admin_teacher.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_teacher.ForeColor = Color.White;
            admin_teacher.Location = new Point(62, 309);
            admin_teacher.Name = "admin_teacher";
            admin_teacher.Size = new Size(170, 53);
            admin_teacher.TabIndex = 0;
            admin_teacher.Text = "TEACHER";
            admin_teacher.UseVisualStyleBackColor = false;
            admin_teacher.Click += admin_teacher_Click_1;
            // 
            // admin_users
            // 
            admin_users.BackColor = Color.Teal;
            admin_users.FlatStyle = FlatStyle.Flat;
            admin_users.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_users.ForeColor = Color.White;
            admin_users.Location = new Point(62, 241);
            admin_users.Name = "admin_users";
            admin_users.Size = new Size(170, 53);
            admin_users.TabIndex = 0;
            admin_users.Text = "USERS";
            admin_users.UseVisualStyleBackColor = false;
            admin_users.Click += admin_users_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button admin_users;
        private Button ad_logout;
        private Button admin_class;
        private Button admin_student;
        private Button admin_teacher;
        private PictureBox pictureBox1;
    }
}