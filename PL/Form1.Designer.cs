namespace PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            log_sPass = new CheckBox();
            log_pass = new TextBox();
            log_user = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            log_lgin = new Button();
            log_exit = new Button();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(log_sPass);
            panel1.Controls.Add(log_pass);
            panel1.Controls.Add(log_user);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(log_lgin);
            panel1.Controls.Add(log_exit);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(289, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 541);
            panel1.TabIndex = 0;
            // 
            // log_sPass
            // 
            log_sPass.AutoSize = true;
            log_sPass.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_sPass.Location = new Point(37, 290);
            log_sPass.Name = "log_sPass";
            log_sPass.Size = new Size(161, 24);
            log_sPass.TabIndex = 3;
            log_sPass.Text = "Show password";
            log_sPass.UseVisualStyleBackColor = true;
            log_sPass.CheckedChanged += log_sPass_CheckedChanged;
            // 
            // log_pass
            // 
            log_pass.BorderStyle = BorderStyle.FixedSingle;
            log_pass.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_pass.Location = new Point(156, 245);
            log_pass.Name = "log_pass";
            log_pass.PasswordChar = '*';
            log_pass.Size = new Size(172, 31);
            log_pass.TabIndex = 2;
            log_pass.Text = "admin123";
            // 
            // log_user
            // 
            log_user.BorderStyle = BorderStyle.FixedSingle;
            log_user.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_user.Location = new Point(160, 185);
            log_user.Name = "log_user";
            log_user.Size = new Size(168, 31);
            log_user.TabIndex = 1;
            log_user.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 247);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 108);
            label3.Name = "label3";
            label3.Size = new Size(150, 39);
            label3.TabIndex = 1;
            label3.Text = "SIGN IN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 187);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // log_lgin
            // 
            log_lgin.BackColor = Color.Teal;
            log_lgin.FlatStyle = FlatStyle.Flat;
            log_lgin.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_lgin.ForeColor = Color.White;
            log_lgin.Location = new Point(114, 430);
            log_lgin.Name = "log_lgin";
            log_lgin.Size = new Size(146, 48);
            log_lgin.TabIndex = 4;
            log_lgin.Text = "LOG IN";
            log_lgin.UseVisualStyleBackColor = false;
            log_lgin.Click += log_lgin_Click;
            // 
            // log_exit
            // 
            log_exit.FlatAppearance.BorderSize = 0;
            log_exit.FlatStyle = FlatStyle.Flat;
            log_exit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_exit.Location = new Point(312, 3);
            log_exit.Name = "log_exit";
            log_exit.Size = new Size(44, 43);
            log_exit.TabIndex = 0;
            log_exit.Text = "X";
            log_exit.UseVisualStyleBackColor = true;
            log_exit.Click += log_exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-1, 294);
            label4.Name = "label4";
            label4.Size = new Size(285, 27);
            label4.TabIndex = 5;
            label4.Text = "SCHOOL MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(97, 321);
            label5.Name = "label5";
            label5.Size = new Size(104, 27);
            label5.TabIndex = 5;
            label5.Text = "SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(648, 541);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox log_pass;
        private TextBox log_user;
        private Label label2;
        private Label label1;
        private Button log_lgin;
        private Button log_exit;
        private CheckBox log_sPass;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
