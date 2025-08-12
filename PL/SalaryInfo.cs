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
using DTO;

namespace PL
{
    public partial class SalaryInfo : Form
    {
        private SalaryBL salaryBL = new SalaryBL();
        private Salary salary = new Salary();
        public SalaryInfo()
        {
            InitializeComponent();
        }

        private void slrupd_save_Click(object sender, EventArgs e)
        {
            salary.ID = slrupd_id.Text;
            salary.IDTEACHER = slrupd_idtch.Text;
            salary.Month = int.Parse(slrupd_month.Text);
            salary.Year = int.Parse((slrupd_year.Text));
            salary.WorkingHours = int.Parse(slrupd_wrkhrs.Text);
            salary.Status = slrupd_sts.Text;

            if (salaryBL.updSalaryDetails(salary))
            {
                MessageBox.Show("Update successfully!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReportDetails(Salary salary)
        {
            slrupd_id.Text = salary.ID;
            slrupd_idtch.Text = salary.IDTEACHER;
            slrupd_month.Text = salary.Month.ToString();
            slrupd_year.Text = salary.Year.ToString();
            slrupd_wrkhrs.Text = salary.WorkingHours.ToString();
            slrupd_sts.Text = salary.Status;

            slrupd_id.Focus();
        }

        private void slrupd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryInfo_Load(object sender, EventArgs e)
        {
            slrupd_idtch.Focus();
        }
    }
}
