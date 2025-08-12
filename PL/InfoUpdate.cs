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
    public partial class InfoUpdate : Form
    {
        private UsersBL usersBL = new UsersBL();
        Users user = new Users();
        private int _id;
        public InfoUpdate()
        {
            InitializeComponent();
        }

        private void info_save_Click(object sender, EventArgs e)
        {
            user.IDUSER = _id;
            user.USERNAME = info_user.Text.Trim();
            user.Passwords = info_pass.Text;
            user.DisplayName = info_displ.Text;
            user.ROLE = info_role.Text;

            if (usersBL.updUser(user))
            {
                MessageBox.Show("Update successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can not update this account!", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InfoUpdate_Load(object sender, EventArgs e)
        {

        }

        public void SetUsers(Users user)
        {
            _id = user.IDUSER;
            info_user.Text = user.USERNAME;
            info_pass.Text = user.Passwords;
            info_displ.Text = user.DisplayName;
            info_role.Text = user.ROLE;

            info_user.Focus();
        }

        private void info_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
