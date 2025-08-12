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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();

        }
        private StudentBL studentBL = new StudentBL();
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            UpdateTotalStudents();
            UpdateTotalOnlStudents();
            UpdateTotalOffStudents();
        }
        private void LoadStudentData()
        {
            try
            {
                var students = studentBL.GetAllStudents();
                dataGridViewStudents.DataSource = students;
                AddButtonColumnsToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:" + ex.Message);
            }
        }

        private void btnStudentAccount_Click(object sender, EventArgs e)
        {
            StudentAccountManangement studentAccountManangement = new StudentAccountManangement();
            this.Close();
            studentAccountManangement.Show();
        }

        private void btnStudentScore_Click(object sender, EventArgs e)
        {
            StudentScoreManagement studentScoreManagement = new StudentScoreManagement();
            this.Hide();
            studentScoreManagement.Show();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentInforForm addStudentInforForm = new AddStudentInforForm(studentBL);
            if (addStudentInforForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentData();
                UpdateTotalStudents();
                UpdateTotalOnlStudents();
                UpdateTotalOffStudents();
            }
        }
        private void UpdateTotalStudents()
        {
            int totalStudents = studentBL.GetTotalStudent();
            lblTotalStudent.Text = totalStudents.ToString();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateTotalOnlStudents()
        {
            int totalOnStudents = studentBL.GetTotalOnlStudents();
            lbtHVconHoc.Text = totalOnStudents.ToString();
        }
        private void UpdateTotalOffStudents()
        {
            int totalOffStudents = studentBL.GetTotalOffStudents();
            lblHVDaNghiHoc.Text = totalOffStudents.ToString();
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
            if (!dataGridViewStudents.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn imageColumnEdit = SetUpImageColumn("Edit.png");
                imageColumnEdit.Name = "Edit";
                imageColumnEdit.HeaderText = "Edit";
                dataGridViewStudents.Columns.Add(imageColumnEdit);
            }
            if (!dataGridViewStudents.Columns.Contains("Delete"))
            {
                DataGridViewImageColumn imageColumnDelete = SetUpImageColumn("delete.png");
                imageColumnDelete.Name = "Delete";
                imageColumnDelete.HeaderText = "Delete";
                dataGridViewStudents.Columns.Add(imageColumnDelete);
            }
        }
        private void dataGridViewStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewStudents.Columns[e.ColumnIndex].Name == "Edit")
            {
                var studentID = dataGridViewStudents.Rows[e.RowIndex].Cells["IDS"].Value.ToString();
                var name = dataGridViewStudents.Rows[e.RowIndex].Cells["NAMESTUDENT"].Value.ToString();
                var gender = dataGridViewStudents.Rows[e.RowIndex].Cells["GENDER"].Value.ToString();
                var bornDate = (DateTime)dataGridViewStudents.Rows[e.RowIndex].Cells["BORNDATE"].Value;
                var idClass = dataGridViewStudents.Rows[e.RowIndex].Cells["IDCLASS"].Value.ToString();
                var states = dataGridViewStudents.Rows[e.RowIndex].Cells["STATES"].Value.ToString();

                UpdateStudentInforForm updateStudentInfor = new UpdateStudentInforForm(studentID, name, gender, bornDate, idClass, states);
                if (updateStudentInfor.ShowDialog() == DialogResult.OK)
                {
                    LoadStudentData();
                    UpdateTotalStudents();
                    UpdateTotalOnlStudents();
                    UpdateTotalOffStudents();
                }
            }
            if (e.RowIndex >= 0 && dataGridViewStudents.Columns[e.ColumnIndex].Name == "Delete")
            {
                var studentID = dataGridViewStudents.Rows[e.RowIndex].Cells["IDS"].Value.ToString();
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    studentBL.DeleteStudent(studentID);
                    MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData();
                    UpdateTotalStudents();
                    UpdateTotalOnlStudents();
                    UpdateTotalOffStudents();
                }

            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncomeManagement studentFee = new IncomeManagement();
            studentFee.ShowDialog();
            this.Close();
        }

        private void btnStudentInfor_Click(object sender, EventArgs e)
        {

        }
    }
}
