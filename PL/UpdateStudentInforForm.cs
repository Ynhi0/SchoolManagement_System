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
using System.Xml.Linq;

namespace PL
{
    public partial class UpdateStudentInforForm : Form
    {
        private string studentId;
        public UpdateStudentInforForm(string studentID, string name, string gender, DateTime bornDate, string idClass, string states)
        {
            InitializeComponent();
            studentId = studentID;
            txtName.Text = name;
            txtStudentId.Text = studentId;
            txtStudentId.ReadOnly = true;
            txtIdClass.Text = idClass;
            cmbGender.Text = gender;
            cmbState.Text = states;
            dTPBornDate.Value = bornDate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStudentInforForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student updateStudent = new Student
            {
                IDS = txtStudentId.Text,
                Name = txtName.Text,
                Gender = cmbGender.Text,
                BornDate = dTPBornDate.Value,
                IDClass = txtIdClass.Text,
                States = cmbState.Text
            };
            StudentBL studentBL = new StudentBL();
            studentBL.UpdateStudent(updateStudent);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
