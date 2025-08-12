using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class StudentAccountManangement : Form
    {
        private StudentBL studentBL = new StudentBL();
        private AccountBL accountBL = new AccountBL();
        public StudentAccountManangement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentAccount addStudentAccount = new AddStudentAccount(accountBL);
            if (addStudentAccount.ShowDialog() == DialogResult.OK)
            {
                LoadStudentAccountData();
            }
        }

        private void StudentAccountManangement_Load(object sender, EventArgs e)
        {
            LoadStudentAccountData();
            UpdateTotalAccount();
        }
        private void LoadStudentAccountData()
        {
            dataGridViewStudentsAccount.DataSource = studentBL.GetStudentAccount();
            AddButtonColumnsToDataGridView();
            lblHVDaKoHĐ.Text = studentBL.GetTotalOffStudents().ToString();
            lblHVconHĐ.Text = studentBL.GetTotalOnlStudents().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement = new StudentManagement();
            this.Close();
            studentManagement.Show();
        }
        private DataGridViewImageColumn SetUpImageColumn(string imgName)
        {
            string appPath = Application.StartupPath;
            var imgFolder = appPath.Remove(appPath.IndexOf("\\bin\\Debug"));

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Image = Image.FromFile(imgFolder + "\\Images\\" + imgName);
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            return imgColumn;
        }


        private void AddButtonColumnsToDataGridView()
        {
            if (!dataGridViewStudentsAccount.Columns.Contains("Delete"))
            {
                DataGridViewImageColumn imageColumnDelete = SetUpImageColumn("delete.png");
                imageColumnDelete.Name = "Delete";
                imageColumnDelete.HeaderText = "Delete";
                dataGridViewStudentsAccount.Columns.Add(imageColumnDelete);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewStudentsAccount.Columns[e.ColumnIndex].Name == "Delete")
            {
                var studentID = dataGridViewStudentsAccount.Rows[e.RowIndex].Cells["IDS"].Value.ToString();
                string studentState = studentBL.GetStudentState(studentID);

                if (studentState != "Nghỉ Học")
                {
                    MessageBox.Show("Học viên này hiện đang hoạt động và không cho phép xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if the student is active
                }
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        studentBL.DeleteStudentAccount(studentID);
                        MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentAccountData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void UpdateTotalAccount()
        {
            lblTotalAccount.Text = accountBL.GetTotalStudentAccount().ToString();
        }
        private void lblTotalAccount_Click(object sender, EventArgs e)
        {
            lblTotalAccount.Text = accountBL.GetTotalStudentAccount().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentScore_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentScoreManagement studentScoreManagement = new StudentScoreManagement();
            studentScoreManagement.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            IncomeManagement incomeManagement = new IncomeManagement();
            incomeManagement.ShowDialog();
        }
    }
}
