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
    public partial class UsersAddForm : Form
    {
        private UsersBL usersBL = new UsersBL();
        private Users user = new Users();
        public UsersAddForm()
        {
            InitializeComponent();
        }
        
        private void useradd_save_Click(object sender, EventArgs e)
        {
            user.USERNAME = useradd_user.Text.Trim();
            user.Passwords = useradd_pass.Text;
            user.ROLE = useradd_role.Text;
            user.DisplayName = useradd_dis.Text;
            

            if (usersBL.addUser(user))
            {
                MessageBox.Show("Add successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can not add this account", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void useradd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
