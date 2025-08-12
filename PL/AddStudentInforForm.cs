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

    public partial class AddStudentInforForm : Form
    {
        private StudentBL studentBL = new StudentBL();
        public AddStudentInforForm(StudentBL studentBL)
        {
            InitializeComponent();
            this.studentBL = studentBL;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student newStudent = new Student()
                {
                    IDS = txtIDS.Text,
                    IDClass = txtIDClass.Text,
                    Name = txtName.Text,
                    Gender = cmbGender.Text,
                    BornDate = dTPBornDate.Value,
                    States = cmbState.Text,
                };
                string studentID = txtIDS.Text.Trim();
                if (studentID.Length < 7)
                {
                    MessageBox.Show("Vui lòng nhập ít nhất 7 ký tự cho Student ID.");
                    txtIDS.Focus();
                    return;
                }
                if(studentBL.CheckIdStudent(studentID) == 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDS.ResetText();
                    return;
                }
                ClassBL classBL = new ClassBL();
                if (classBL.CheckExistClass(txtIDClass.Text) == 0)
                {
                    MessageBox.Show("Lớp học không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDClass.ResetText();
                    return;
                }
                studentBL.AddStudent(newStudent);
                MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
