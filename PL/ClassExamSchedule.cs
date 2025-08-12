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
    public partial class ClassExamSchedule : Form
    {
        private SemesterBL semesterBL = new SemesterBL();
        private ClassBL classBL = new ClassBL();
        public ClassExamSchedule()
        {
            InitializeComponent();
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
            if (!dataGridViewExamSchedule.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn imageColumnEdit = SetUpImageColumn("Edit.png");
                imageColumnEdit.Name = "Edit";
                imageColumnEdit.HeaderText = "Edit";
                dataGridViewExamSchedule.Columns.Add(imageColumnEdit);
            }
            if (!dataGridViewExamSchedule.Columns.Contains("Delete"))
            {
                DataGridViewImageColumn imageColumnDelete = SetUpImageColumn("delete.png");
                imageColumnDelete.Name = "Delete";
                imageColumnDelete.HeaderText = "Delete";
                dataGridViewExamSchedule.Columns.Add(imageColumnDelete);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadExamSchedule()
        {
            try
            {
                var examSchedule = semesterBL.getSemesterDate();
                dataGridViewExamSchedule.DataSource = examSchedule;
                AddButtonColumnsToDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:" + ex.Message);
            }
        }

        private void ClassExamSchedule_Load(object sender, EventArgs e)
        {
            LoadExamSchedule();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentExamSchedule addStudentExamSchedule = new AddStudentExamSchedule(semesterBL);
            if (addStudentExamSchedule.ShowDialog() == DialogResult.OK)
            {
                LoadExamSchedule();
            }
        }
     
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassManagement classManagement = new ClassManagement();
            classManagement.Show();
        }

        private void btnEnrollClass_Click(object sender, EventArgs e)
        {
            this.Close();
            EnrollClassManagement enrollClassManagement = new EnrollClassManagement();
            enrollClassManagement.Show();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassTimeTable timeTableManagement = new ClassTimeTable();
            timeTableManagement.Show();
        }

        private void lblTotalClass_Click(object sender, EventArgs e)
        {

        }

        private void lblOffClass_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewExamSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewExamSchedule.Columns[e.ColumnIndex].Name == "Edit")
            {
                var idClass = dataGridViewExamSchedule.Rows[e.RowIndex].Cells["IDCLASS"].Value.ToString();
               
                var writingTest = (DateTime)dataGridViewExamSchedule.Rows[e.RowIndex].Cells["WRITINGTEST"].Value;
                var speakingTest = (DateTime)dataGridViewExamSchedule.Rows[e.RowIndex].Cells["SPEAKINGTEST"].Value;
                var listeningTest = (DateTime)dataGridViewExamSchedule.Rows[e.RowIndex].Cells["LISTENINGTEST"].Value;
                var readingTest = (DateTime)dataGridViewExamSchedule.Rows[e.RowIndex].Cells["READINGTEST"].Value;
                UpdateExamDate updateExam = new UpdateExamDate(idClass, writingTest, speakingTest, listeningTest, readingTest);
                if (updateExam.ShowDialog() == DialogResult.OK)
                {
                    LoadExamSchedule();
                }
            }
            if (e.RowIndex >= 0 && dataGridViewExamSchedule.Columns[e.ColumnIndex].Name == "Delete")
            {
                var idClass = dataGridViewExamSchedule.Rows[e.RowIndex].Cells["IDCLASS"].Value.ToString();
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    semesterBL.DeleteExamDate(idClass);
                    MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExamSchedule();
                }

            }
        }
    }
}
