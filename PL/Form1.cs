using BL;
using DTO;

namespace PL
{
    public partial class Form1 : Form
    {
        Users user = new Users();
        private LoginBL loginBL = new LoginBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void log_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_lgin_Click(object sender, EventArgs e)
        {
            user.USERNAME = log_user.Text.Trim();
            user.Passwords = log_pass.Text.Trim();

            if (loginBL.LoginValidation(user))
            {
                MessageBox.Show("Login successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log_user.Clear();
                log_pass.Clear();
                log_user.Focus();
            }
        }

        private void log_sPass_CheckedChanged(object sender, EventArgs e)
        {
            log_pass.PasswordChar = log_sPass.Checked ? '\0' : '*';
        }
    }
}
