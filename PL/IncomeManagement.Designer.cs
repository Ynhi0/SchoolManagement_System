namespace PL
{
    partial class IncomeManagement
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            btnStudentAccount = new Button();
            btnStudentInfor = new Button();
            btnStudentScore = new Button();
            btnReturn = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel3 = new Panel();
            cmbGender = new ComboBox();
            lblGT = new Label();
            txtIDClass = new TextBox();
            lblIdClass = new Label();
            txtNS = new TextBox();
            lblNS = new Label();
            txtName = new TextBox();
            lblName = new Label();
            panel4 = new Panel();
            dataGridViewStudentFee = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentFee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(11, 5);
            label1.Name = "label1";
            label1.Size = new Size(356, 38);
            label1.TabIndex = 4;
            label1.Text = "Student Fee Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnStudentAccount);
            panel2.Controls.Add(btnStudentInfor);
            panel2.Controls.Add(btnStudentScore);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 61);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 729);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(54, 522);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 66);
            button2.TabIndex = 27;
            button2.Text = "Student's Fee";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnStudentAccount
            // 
            btnStudentAccount.BackColor = Color.Teal;
            btnStudentAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentAccount.ForeColor = Color.White;
            btnStudentAccount.Location = new Point(54, 263);
            btnStudentAccount.Margin = new Padding(3, 2, 3, 2);
            btnStudentAccount.Name = "btnStudentAccount";
            btnStudentAccount.Size = new Size(170, 66);
            btnStudentAccount.TabIndex = 23;
            btnStudentAccount.Text = "Student's Account";
            btnStudentAccount.UseVisualStyleBackColor = false;
            btnStudentAccount.Click += btnStudentAccount_Click;
            // 
            // btnStudentInfor
            // 
            btnStudentInfor.BackColor = Color.Teal;
            btnStudentInfor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfor.ForeColor = Color.White;
            btnStudentInfor.Location = new Point(54, 347);
            btnStudentInfor.Margin = new Padding(3, 2, 3, 2);
            btnStudentInfor.Name = "btnStudentInfor";
            btnStudentInfor.Size = new Size(170, 66);
            btnStudentInfor.TabIndex = 24;
            btnStudentInfor.Text = "Student's \r\nInformation";
            btnStudentInfor.UseVisualStyleBackColor = false;
            btnStudentInfor.Click += btnStudentInfor_Click;
            // 
            // btnStudentScore
            // 
            btnStudentScore.BackColor = Color.Teal;
            btnStudentScore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentScore.ForeColor = Color.White;
            btnStudentScore.Location = new Point(52, 435);
            btnStudentScore.Margin = new Padding(3, 2, 3, 2);
            btnStudentScore.Name = "btnStudentScore";
            btnStudentScore.Size = new Size(170, 66);
            btnStudentScore.TabIndex = 25;
            btnStudentScore.Text = "Student's Score";
            btnStudentScore.UseVisualStyleBackColor = false;
            btnStudentScore.Click += btnStudentScore_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Teal;
            btnReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(54, 637);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(170, 66);
            btnReturn.TabIndex = 26;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(78, 55);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(59, 808);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 64);
            button1.TabIndex = 0;
            button1.Text = "RETURN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbGender);
            panel3.Controls.Add(lblGT);
            panel3.Controls.Add(txtIDClass);
            panel3.Controls.Add(lblIdClass);
            panel3.Controls.Add(txtNS);
            panel3.Controls.Add(lblNS);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(lblName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(295, 61);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1205, 256);
            panel3.TabIndex = 2;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGender.Location = new Point(176, 170);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(282, 36);
            cmbGender.TabIndex = 9;
            // 
            // lblGT
            // 
            lblGT.AutoSize = true;
            lblGT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGT.Location = new Point(51, 171);
            lblGT.Name = "lblGT";
            lblGT.Size = new Size(99, 28);
            lblGT.TabIndex = 8;
            lblGT.Text = "Giới Tính";
            // 
            // txtIDClass
            // 
            txtIDClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDClass.Location = new Point(640, 34);
            txtIDClass.Margin = new Padding(3, 4, 3, 4);
            txtIDClass.Name = "txtIDClass";
            txtIDClass.Size = new Size(282, 34);
            txtIDClass.TabIndex = 5;
            // 
            // lblIdClass
            // 
            lblIdClass.AutoSize = true;
            lblIdClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdClass.Location = new Point(513, 38);
            lblIdClass.Name = "lblIdClass";
            lblIdClass.Size = new Size(100, 28);
            lblIdClass.TabIndex = 4;
            lblIdClass.Text = "Class's ID";
            // 
            // txtNS
            // 
            txtNS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNS.Location = new Point(176, 101);
            txtNS.Margin = new Padding(3, 4, 3, 4);
            txtNS.Name = "txtNS";
            txtNS.Size = new Size(282, 34);
            txtNS.TabIndex = 3;
            // 
            // lblNS
            // 
            lblNS.AutoSize = true;
            lblNS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNS.Location = new Point(49, 105);
            lblNS.Name = "lblNS";
            lblNS.Size = new Size(104, 28);
            lblNS.TabIndex = 2;
            lblNS.Text = "Năm Sinh";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(176, 34);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 34);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(49, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(106, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và Tên";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewStudentFee);
            panel4.Location = new Point(327, 325);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1136, 625);
            panel4.TabIndex = 3;
            // 
            // dataGridViewStudentFee
            // 
            dataGridViewStudentFee.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStudentFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStudentFee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentFee.EnableHeadersVisualStyles = false;
            dataGridViewStudentFee.Location = new Point(0, 0);
            dataGridViewStudentFee.Margin = new Padding(3, 4, 3, 4);
            dataGridViewStudentFee.Name = "dataGridViewStudentFee";
            dataGridViewStudentFee.RowHeadersWidth = 51;
            dataGridViewStudentFee.RowTemplate.Height = 24;
            dataGridViewStudentFee.Size = new Size(1136, 443);
            dataGridViewStudentFee.TabIndex = 0;
            dataGridViewStudentFee.CellContentClick += dataGridViewStudentFee_CellContentClick;
            // 
            // IncomeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "IncomeManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IncomeManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentFee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewStudentFee;
        private System.Windows.Forms.TextBox txtIDClass;
        private System.Windows.Forms.Label lblIdClass;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button button2;
        private Button btnStudentAccount;
        private Button btnStudentInfor;
        private Button btnStudentScore;
        private Button btnReturn;
    }
}