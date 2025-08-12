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
    public partial class AddTeacherForm : Form
    {
        Teacher teacher = new Teacher();
        TeacherBL teacherBL = new TeacherBL();
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void addtch_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addtch_save_Click(object sender, EventArgs e)
        {
            teacher.IDUSER = int.Parse(addtch_iduser.Text);
            teacher.IDTEACHER = addtch_idtch.Text.Trim();
            teacher.NAMEOFTEACHER = addtch_name.Text;
            teacher.GENDER = addtch_gender.Text;
            teacher.BORNDATE = addtch_birth.Text;
            teacher.ADDRESSOFTEACHER = addtch_address.Text;
            teacher.SALARY = int.Parse(addtch_slr.Text);
            teacher.PHONE = addtch_phn.Text;
            teacher.STATUS = addtch_sts.Text;
            teacher.SALARYCOEFFICIENT = decimal.Parse(addtch_slrcf.Text);

            if (teacherBL.addTeacher(teacher))
            {
                MessageBox.Show("Add successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can not add this teacher!", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            addtch_iduser.Focus();
        }
    }
}
