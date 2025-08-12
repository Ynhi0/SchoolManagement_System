using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BL;
namespace PL
{
    public partial class IncomeManagement : Form
    {
        private StudentBL studentBL = new StudentBL();
        public IncomeManagement()
        {
            InitializeComponent();
            LoadStudentFeeData();
            AddButtonColumnsToDataGridView();
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
            if (!dataGridViewStudentFee.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn imageColumnEdit = SetUpImageColumn("Edit.png");
                imageColumnEdit.Name = "Edit";
                imageColumnEdit.HeaderText = "Edit";
                dataGridViewStudentFee.Columns.Add(imageColumnEdit);
            }
        }
        private void LoadStudentFeeData()
        {
            var studentFee = studentBL.GetAllStudentFee();
            dataGridViewStudentFee.DataSource = studentFee;
        }

        private void dataGridViewStudentFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var studentID = dataGridViewStudentFee.Rows[e.RowIndex].Cells["IDS"].Value.ToString();
                var student = studentBL.GetStudentDetailByID(studentID);

                txtName.Text = student.Name;
                txtIDClass.Text = student.IDClass;
                cmbGender.Text = student.Gender.ToString();
                txtNS.Text = student.BornDate.ToString("dd-MM-yyyy");
            }

            if (e.RowIndex >= 0 && dataGridViewStudentFee.Columns[e.ColumnIndex].Name == "Edit")
            {

                var idStudent = dataGridViewStudentFee.Rows[e.RowIndex].Cells["IDS"].Value.ToString();
                var month = Int32.Parse(dataGridViewStudentFee.Rows[e.RowIndex].Cells["MONTHS"].Value.ToString());
                var dueDate = (DateTime)dataGridViewStudentFee.Rows[e.RowIndex].Cells["DUEDATE"].Value;
                var state = dataGridViewStudentFee.Rows[e.RowIndex].Cells["STATE"].Value.ToString();
                var tuitionFee = Int32.Parse(dataGridViewStudentFee.Rows[e.RowIndex].Cells["TUITIONFEE"].Value.ToString());




                EditStudentFee editStudentFee = new EditStudentFee(idStudent, month, dueDate, state, tuitionFee);
                if (editStudentFee.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentFeeData();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void btnStudentAccount_Click(object sender, EventArgs e)
        {
            StudentAccountManangement studentAccount = new StudentAccountManangement();
            studentAccount.ShowDialog();
            this.Close();
        }

        private void btnStudentInfor_Click(object sender, EventArgs e)
        {
            StudentManagement student = new StudentManagement();
            student.ShowDialog();
            this.Close();
        }

        private void btnStudentScore_Click(object sender, EventArgs e)
        {
            StudentScoreManagement studentScore = new StudentScoreManagement();
            studentScore.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
