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
    public partial class TeacherInfoUpdate : Form
    {
        private Teacher teacher = new Teacher();
        private TeacherBL teacherBL = new TeacherBL();
        public TeacherInfoUpdate()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            teacher.IDTEACHER = idtch.Text;
            teacher.NAMEOFTEACHER = name.Text;
            teacher.GENDER = gender.Text;
            teacher.BORNDATE = birth.Text;
            teacher.ADDRESSOFTEACHER = address.Text;
            teacher.SALARY = int.Parse(salary.Text);
            teacher.SALARYCOEFFICIENT = decimal.Parse(slrcoef.Text);
            teacher.PHONE = phone.Text;
            teacher.STATUS = status.Text;

            if (teacherBL.updTeacher(teacher))
            {
                MessageBox.Show("Update successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Updat failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetTeacher(Teacher teacher)
        {
            idtch.Text = teacher.IDTEACHER;
            name.Text = teacher.NAMEOFTEACHER;
            gender.Text = teacher.GENDER;
            birth.Text = teacher.BORNDATE;
            address.Text = teacher.ADDRESSOFTEACHER;
            salary.Text = teacher.SALARY.ToString();
            slrcoef.Text = teacher.SALARYCOEFFICIENT.ToString();
            phone.Text = teacher.PHONE;
            status.Text = teacher.STATUS;

            name.Focus();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
