using BL;
using DTO;
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
    public partial class AddStudentExamSchedule : Form
    {
        private SemesterBL semesterBL = new SemesterBL();

        public AddStudentExamSchedule(SemesterBL semesterBL)
        {
            InitializeComponent();
            this.semesterBL = semesterBL;
            txtClassName.ReadOnly = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadIDClassIntoComboBox()
        {
            cmbIDClass.Items.Clear();
            var classes = semesterBL.GetIdClass();
            DataRow emptyRow = classes.NewRow();
            emptyRow["IDCLASS"] = string.Empty;

            classes.Rows.InsertAt(emptyRow, 0);

            cmbIDClass.DataSource = classes;
            cmbIDClass.DisplayMember = "IDCLASS";
            cmbIDClass.ValueMember = "IDCLASS";

            cmbIDClass.SelectedIndex = 0;
            cmbIDClass.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void cmbIDClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbIDClass.SelectedIndex == 0)
            {
                txtClassName.Clear();
                return;
            }

            var selectedIdclass = cmbIDClass.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(selectedIdclass))
            {
                var className = semesterBL.GetClassNameByID(selectedIdclass);
                txtClassName.Text = className;
            }
        }

        private void AddStudentExamSchedule_Load(object sender, EventArgs e)
        {
            LoadIDClassIntoComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Semester newSemester = new Semester
                {
                    IdClass = cmbIDClass.SelectedValue.ToString(),
                    listeningTest = dTPListeningTest.Value,
                    readingTest = dTPReadingTest.Value,
                    speakingTest = dTPSpeakingTest.Value,
                    writingTest = dTPWritingTest.Value
                };
                bool result = semesterBL.AddSemesterDate(newSemester);
                if (result)
                {
                    MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra khi thêm thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
