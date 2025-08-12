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
    public partial class EditStudentFee : Form
    {
        private string IDStudent;
        private StudentBL studentBL = new StudentBL();
        public EditStudentFee(string idStudent, int month, DateTime Duedate, string state, int tuitionFee)
        {
            InitializeComponent();
            Student student = studentBL.GetStudentDetailByID(idStudent);

            IDStudent = idStudent;
            txtIDS.Text = idStudent;
            txtIDS.ReadOnly = true;
            txtName.Text = student.Name;
            txtName.ReadOnly = true;
            cmbMonth.Text = month.ToString();
            dTPDuedate.Value = Duedate;
            cmbState.Text = state;
            txtTuitionFee.Text = tuitionFee.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student studentFee = new Student
                {
                    IDS = IDStudent,
                    Name = txtName.Text,
                    Month = Int32.Parse(cmbMonth.Text),
                    States = cmbState.Text,
                    TuitionFee = Int32.Parse(txtTuitionFee.Text),
                    DueDate = dTPDuedate.Value
                };
                studentBL.UpdateStudentFee(studentFee);
                MessageBox.Show("Sửa thông tin  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
