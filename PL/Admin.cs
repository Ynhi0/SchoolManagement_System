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

namespace PL
{
    public partial class Admin : Form
    {
        private UsersBL userBL = new UsersBL();
        public Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want ot log out ?", "Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void usersManagement1_Load(object sender, EventArgs e)
        {

        }

        private void admin_teacher_Click(object sender, EventArgs e)
        {

        }

        private void admin_teacher_Click_1(object sender, EventArgs e)
        {
            TeacherForm tchfrm = new TeacherForm();
            tchfrm.Show();
            this.Hide();
        }

        private void admin_users_Click(object sender, EventArgs e)
        {
            UsersForm userfrm = new UsersForm();
            userfrm.Show();
            this.Hide();
        }

        private void admin_student_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Show();
            this.Hide();
        }

        private void admin_class_Click(object sender, EventArgs e)
        {
            ClassManagement classManagement = new ClassManagement();
            classManagement.Show();
        }
    }
}
