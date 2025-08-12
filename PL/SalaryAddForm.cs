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
    public partial class SalaryAddForm : Form
    {
        Salary salary = new Salary();
        private SalaryBL salaryBL = new SalaryBL();
        public SalaryAddForm()
        {
            InitializeComponent();
        }

        private void slradd_add_Click(object sender, EventArgs e)
        {
            salary.ID = slradd_ID.Text.Trim();
            salary.IDTEACHER = slradd_idtch.Text.Trim();
            salary.Month = int.Parse(slradd_month.Text);
            salary.Year = int.Parse(slradd_year.Text);
            salary.WorkingHours = int.Parse(slradd_wrkhrs.Text);
            salary.Status = slradd_sts.Text;

            if (salaryBL.addSalaryDetails(salary))
            {
                MessageBox.Show("Add successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Add failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void slradd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryAddForm_Load(object sender, EventArgs e)
        {
            slradd_ID.Focus();
        }
    }
}
