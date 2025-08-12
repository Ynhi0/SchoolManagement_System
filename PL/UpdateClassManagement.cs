using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DTO;

namespace PL
{
    public partial class UpdateClassManagement : Form
    {
        private string IdClass;
        private TeacherBL teacherBL = new TeacherBL();
        public UpdateClassManagement(string IdClass, string className, DateTime startDate, DateTime endDate, int caHoc,
            string idTeacher, string state, string timeTable, int room, int num)
        {
            InitializeComponent();
            LoadComboBoxes();
            txtTeacherName.Text = teacherBL.GetTeacherNameByID(cmbTeacherID.Text);
            txtTeacherName.ReadOnly = true;
            LoadIDTeacherList();
            this.IdClass = IdClass;
            txtIDclass.Text = IdClass;
            txtClassName.Text = className;
            txtClassName.ReadOnly = true;
            dTPStartDate.Value = startDate;
            dTPEndDate.Value = endDate;
            cmbClassShift.SelectedItem = caHoc;
            cmbTeacherID.SelectedItem = idTeacher;
            cmbBoxState.SelectedItem = state;
            cmbTimeTable.SelectedItem = timeTable;
            cmbRoom.SelectedItem = room;
            txtNumberOfStudent.Text = num.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class newClass = new Class
            {
                IDClass = txtIDclass.Text,
                Name = txtClassName.Text,
                CaHoc = Int32.Parse(cmbClassShift.Text),
                startDate = dTPStartDate.Value,
                endDate = dTPEndDate.Value,
                IDTeacher = cmbTeacherID.Text,
                Timetable = cmbTimeTable.Text,
                States = cmbBoxState.Text,
                Room = Int32.Parse(cmbRoom.Text),
                numberOfStudent = Int32.Parse(txtNumberOfStudent.Text)
            };
            ClassBL classBL = new ClassBL();
            classBL.UpdateClassDetails(newClass);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadComboBoxes()
        {
            // Populate ComboBoxes here
            for (int i = 1; i <= 4; i++)
            {
                cmbClassShift.Items.Add(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                cmbRoom.Items.Add(i);
            }
        }
        private void cmbClassShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                cmbClassShift.Items.Add(i);
            }

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
            var selectedIdTeacher = cmbTeacherID.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(selectedIdTeacher))
            {
                var teacherName = teacherBL.GetTeacherNameByID(selectedIdTeacher);
                txtTeacherName.Text = teacherName;
            }
        }
    }
}
