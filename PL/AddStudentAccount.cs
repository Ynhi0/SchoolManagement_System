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
    public partial class AddStudentAccount : Form
    {
        private StudentBL studentBL = new StudentBL();
        private AccountBL accountBL = new AccountBL();
        public AddStudentAccount(AccountBL accountBL)
        {
            InitializeComponent();
            this.accountBL = accountBL;
            txtIDUser.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtDisplayName.ReadOnly = true;
        }

        private void txtDisplayName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtStudentID_Leave(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            if (studentID.Length < 7)
            {
                MessageBox.Show("Vui lòng nhập ít nhất 7 ký tự cho Student ID.");
                txtStudentID.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(studentID))
            {
                if (accountBL.StudentAccountExists(studentID))
                {
                    MessageBox.Show("Học viên này đã có tài khoản.");
                    txtStudentID.ResetText();
                    return;
                }
                //lấy thông tin học viên
                Student student = studentBL.GetStudentDetailByID(studentID);

                if (student == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên trùng với Student ID.");

                }
                else
                {
                   
                    txtIDUser.Text = (accountBL.GetMaxUserId() + 1).ToString();
                    txtUsername.Text = studentID;
                    txtDisplayName.Text = student.Name;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount = new Account
                {
                    Username = txtUsername.Text,
                    DisplayName = txtDisplayName.Text,
                    Password = txtPassword.Text,
                    Iduser = int.Parse(txtIDUser.Text)

                };
                accountBL.AddStudentAccount(newAccount);
                MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK
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
