using BL;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace PL
{
    public partial class UsersForm : Form
    {
        private UsersBL usersBL = new UsersBL();
        Users user = new Users();
        public UsersForm()
        {
            InitializeComponent();
        }

        private void ad_add_Click(object sender, EventArgs e)
        {
            UsersAddForm form = new UsersAddForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                AccountData.DataSource = usersBL.getUsers();
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            AccountData.DataSource = usersBL.getUsers();
            AddEditButton();
        }

        private void AddEditButton()
        {
            if (!AccountData.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn imgColumn = CustomImageColumn("Edit.png");
                imgColumn.Name = "Edit";
                imgColumn.HeaderText = "Edit";
                AccountData.Columns.Add(imgColumn);
            }

            if (!AccountData.Columns.Contains("Delete"))
            {
                DataGridViewImageColumn delcol = CustomImageColumn("delete.png");
                delcol.Name = "Delete";
                delcol.HeaderText = "Delete";
                AccountData.Columns.Add(delcol);
            }
        }

        private DataGridViewImageColumn CustomImageColumn(string imgName)
        {
            string appPath = Application.StartupPath;
            var imgFolder = appPath.Remove(appPath.IndexOf("\\bin\\Debug"));

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Image = Image.FromFile(imgFolder + "\\Images\\" + imgName);
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            return imgColumn;
        }

        private void AccountData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AccountData.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                user.IDUSER = Int32.Parse(AccountData.Rows[e.RowIndex].Cells["IDUSER"].Value.ToString());
                user.USERNAME = AccountData.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString() ?? string.Empty;
                user.Passwords = AccountData.Rows[e.RowIndex].Cells["Passwords"].Value.ToString() ?? string.Empty;
                user.DisplayName = AccountData.Rows[e.RowIndex].Cells["DisplayName"].Value.ToString() ?? string.Empty;
                user.ROLE = AccountData.Rows[e.RowIndex].Cells["ROLE"].Value.ToString() ?? string.Empty;

                InfoUpdate info = new InfoUpdate();
                info.SetUsers(user);

                if (info.ShowDialog() == DialogResult.OK)
                {
                    RefreshDataGridView();
                }
            }

            if (e.ColumnIndex == AccountData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                user.IDUSER = Int32.Parse(AccountData.Rows[e.RowIndex].Cells["IDUSER"].Value.ToString());

                DialogResult dl = MessageBox.Show("Do you want to delete this account ?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (usersBL.delUser(user))
                    {
                        MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Can not delete this account!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RefreshDataGridView()
        {
            AccountData.DataSource = usersBL.getUsers();
        }

        private void ad_search_TextChanged(object sender, EventArgs e)
        {
            string filtertext = ad_search.Text.Trim();
            DataTable filter = usersBL.searchUser(filtertext);
            if (string.IsNullOrEmpty(ad_search.Text))
            {
                AccountData.DataSource = usersBL.getUsers();
            }
            else
            {
                AccountData.DataSource = filter;
            }
        }

        private void ad_logout_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
