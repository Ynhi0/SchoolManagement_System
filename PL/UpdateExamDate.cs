using BL;
using DL;
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
using System.Xml.Linq;

namespace PL
{
    public partial class UpdateExamDate : Form
    {
        ClassBL classBL = new ClassBL();
        SemesterBL semesterBL = new SemesterBL();
        public UpdateExamDate(string idClass, DateTime writingTest, DateTime speakingTest, DateTime listeningTest, DateTime readingTest)
        {
            InitializeComponent();
            cmbIDClass.Text = idClass;
            cmbIDClass.Enabled = true;
            dTPListeningTest.Value = writingTest;
            dTPReadingTest.Value = readingTest;
            dTPSpeakingTest.Value = speakingTest;
            dTPWritingTest.Value = listeningTest;
            txtClassName.ReadOnly = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Semester semester = new Semester
            {
                IdClass = cmbIDClass.Text,
                writingTest = dTPWritingTest.Value,
                speakingTest = dTPSpeakingTest.Value,
                listeningTest = dTPListeningTest.Value,
                readingTest = dTPReadingTest.Value
            };
            SemesterBL semesterBL = new SemesterBL();
            semesterBL.UpdateSemesterDate(semester);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

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
    }
}
