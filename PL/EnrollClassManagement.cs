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
using System.Windows.Forms.VisualStyles;
using DTO;

namespace PL
{
    public partial class EnrollClassManagement : Form
    {
        private ClassBL classBL = new ClassBL();
        private TeacherBL teacherBL = new TeacherBL();
        public EnrollClassManagement()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
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
            if (!dataGridViewClass.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn imageColumnEdit = SetUpImageColumn("Edit.png");
                imageColumnEdit.Name = "Edit";
                imageColumnEdit.HeaderText = "Edit";
                dataGridViewClass.Columns.Add(imageColumnEdit);
            }
            if (!dataGridViewClass.Columns.Contains("Delete"))
            {
                DataGridViewImageColumn imageColumnDelete = SetUpImageColumn("delete.png");
                imageColumnDelete.Name = "Delete";
                imageColumnDelete.HeaderText = "Delete";
                dataGridViewClass.Columns.Add(imageColumnDelete);
            }
        }
        private void LoadListOfClass()
        {
            var dt = classBL.GetAllClass();
            dataGridViewClass.DataSource = dt;
            AddButtonColumnsToDataGridView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumberOfStudent.Text))
            {
                MessageBox.Show("Điền thông tin đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numberOfstudent = Int32.Parse(txtNumberOfStudent.Text);
            if (numberOfstudent <= 0)
            {
                MessageBox.Show("Số lượng học sinh phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime startDate = dTPStartDate.Value;
            DateTime endDate = dTPEndDate.Value;
            if (endDate <= startDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Class newClass = new Class
                {
                    IDClass = txtClassName.Text,
                    Name = txtClassName.Text,
                    CaHoc = Int32.Parse(cmbClassShift.Text),
                    numberOfStudent = int.Parse(txtNumberOfStudent.Text),
                    startDate = dTPEndDate.Value,
                    endDate = dTPEndDate.Value,
                    IDTeacher = cmbTeacherID.Text,
                    Timetable = cmbTimeTable.Text,
                    States = cmbBoxState.Text,
                    Room = int.Parse(cmbRoom.Text)
                };
                classBL.AddClassDetails(newClass);
                MessageBox.Show("Thêm Lớp Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListOfClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnrollClassManagement_Load(object sender, EventArgs e)
        {
            txtTeacherName.ReadOnly = true;
            txtTeacherName.Text = teacherBL.GetTeacherNameByID(cmbTeacherID.Text);
            LoadIDTeacherList();
            LoadListOfClass();
        }
        private void LoadIDTeacherList()
        {
            cmbTeacherID.Items.Clear();
            var idTeacherList = teacherBL.getIDTeacherList();
            cmbTeacherID.DataSource = idTeacherList;
            cmbTeacherID.DisplayMember = "IDTeacher";
            cmbTeacherID.ValueMember = "IDTeacher";
        }

        private void cmbTeacherID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIdTeacher = cmbTeacherID.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedIdTeacher))
            {
                var teacherName = teacherBL.GetTeacherNameByID(selectedIdTeacher);
                txtTeacherName.Text = teacherName;
            }
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassManagement classManagement = new ClassManagement();
            classManagement.ShowDialog();
        }


        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassTimeTable classTimeTable = new ClassTimeTable();
            classTimeTable.ShowDialog();
        }

        private void btnExamSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassExamSchedule examSchedule = new ClassExamSchedule();
            examSchedule.ShowDialog();
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewClass.Columns[e.ColumnIndex].Name == "Edit")
            {

                var idClass = dataGridViewClass.Rows[e.RowIndex].Cells["IDCLASS"].Value.ToString();
                var name = dataGridViewClass.Rows[e.RowIndex].Cells["CLASSNAME"].Value.ToString();
                var states = dataGridViewClass.Rows[e.RowIndex].Cells["STATES"].Value.ToString();
                var startDate = (DateTime)dataGridViewClass.Rows[e.RowIndex].Cells["STARTDATE"].Value;
                var endDate = (DateTime)dataGridViewClass.Rows[e.RowIndex].Cells["ENDDATE"].Value;
                var idTeacher = dataGridViewClass.Rows[e.RowIndex].Cells["IDTEACHER"].Value.ToString();
                var caHoc = Int32.Parse(dataGridViewClass.Rows[e.RowIndex].Cells["CAHOC"].Value.ToString() ?? string.Empty);
                var room = Int32.Parse(dataGridViewClass.Rows[e.RowIndex].Cells["ROOM"].Value.ToString() ?? string.Empty);
                var timeTable = dataGridViewClass.Rows[e.RowIndex].Cells["TIMETABLE"].Value.ToString();
                var numOfStudent = int.Parse(dataGridViewClass.Rows[e.RowIndex].Cells["NUMBEROFSTUDENT"].Value.ToString() ?? string.Empty);



                UpdateClassManagement updateClass = new UpdateClassManagement(idClass, name, startDate, endDate, caHoc, idTeacher, states, timeTable, room, numOfStudent);
                if (updateClass.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadListOfClass();
                }
            }
            //Xóa trong trường hợp chưa có học sinh học
            if (e.RowIndex >= 0 && dataGridViewClass.Columns[e.ColumnIndex].Name == "Delete")
            {
                var classID = dataGridViewClass.Rows[e.RowIndex].Cells["IDCLASS"].Value.ToString();
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    classBL.DeleteClassDetails(classID);
                    MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListOfClass();
                }

            }

        }

        private void cmbClassShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                cmbClassShift.Items.Add(i);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTeacherName.ResetText();
            txtClassName.ResetText();
            txtNumberOfStudent.ResetText();
            txtIDclass.ResetText();
            cmbBoxState.ResetText();
            cmbClassShift.ResetText();
            cmbTimeTable.ResetText();
            cmbTeacherID.ResetText();
            cmbRoom.ResetText();

        }
    }
}
