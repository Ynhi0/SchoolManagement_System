namespace PL
{
    partial class UsersForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            ad_logout = new Button();
            search = new Label();
            ad_search = new TextBox();
            AccountData = new DataGridView();
            ad_add = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountData).BeginInit();
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
            label1.Size = new Size(189, 23);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ad_logout);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 747);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school;
            pictureBox1.Location = new Point(75, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 205);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 0;
            label3.Text = "SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 182);
            label2.Name = "label2";
            label2.Size = new Size(249, 23);
            label2.TabIndex = 0;
            label2.Text = "SCHOOL MANAGEMENT";
            // 
            // ad_logout
            // 
            ad_logout.BackColor = Color.Teal;
            ad_logout.FlatStyle = FlatStyle.Flat;
            ad_logout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ad_logout.ForeColor = Color.White;
            ad_logout.Location = new Point(63, 682);
            ad_logout.Name = "ad_logout";
            ad_logout.Size = new Size(170, 53);
            ad_logout.TabIndex = 0;
            ad_logout.Text = "RETURN";
            ad_logout.UseVisualStyleBackColor = false;
            ad_logout.Click += ad_logout_Click;
            // 
            // search
            // 
            search.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.ForeColor = Color.Teal;
            search.Location = new Point(1038, 67);
            search.Name = "search";
            search.Size = new Size(88, 25);
            search.TabIndex = 10;
            search.Text = "Search:";
            // 
            // ad_search
            // 
            ad_search.BorderStyle = BorderStyle.FixedSingle;
            ad_search.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ad_search.Location = new Point(1132, 65);
            ad_search.Name = "ad_search";
            ad_search.Size = new Size(343, 31);
            ad_search.TabIndex = 12;
            ad_search.TextChanged += ad_search_TextChanged;
            // 
            // AccountData
            // 
            AccountData.AllowUserToAddRows = false;
            AccountData.AllowUserToDeleteRows = false;
            AccountData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AccountData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AccountData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountData.EnableHeadersVisualStyles = false;
            AccountData.Location = new Point(324, 102);
            AccountData.Name = "AccountData";
            AccountData.ReadOnly = true;
            AccountData.RowHeadersVisible = false;
            AccountData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            AccountData.Size = new Size(1151, 608);
            AccountData.TabIndex = 9;
            AccountData.CellClick += AccountData_CellClick;
            // 
            // ad_add
            // 
            ad_add.BackColor = Color.Teal;
            ad_add.FlatStyle = FlatStyle.Flat;
            ad_add.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ad_add.ForeColor = Color.White;
            ad_add.Location = new Point(372, 725);
            ad_add.Name = "ad_add";
            ad_add.Size = new Size(129, 53);
            ad_add.TabIndex = 11;
            ad_add.Text = "ADD";
            ad_add.UseVisualStyleBackColor = false;
            ad_add.Click += ad_add_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(search);
            Controls.Add(ad_search);
            Controls.Add(AccountData);
            Controls.Add(ad_add);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersForm";
            Load += UsersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button ad_logout;
        private Label search;
        private TextBox ad_search;
        private DataGridView AccountData;
        private Button ad_add;
        private Label label3;
        private Label label2;
    }
}