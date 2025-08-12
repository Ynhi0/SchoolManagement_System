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
    public partial class SalaryExecutingForm : Form
    {
        private SalaryBL salaryBL = new SalaryBL();
        private Salary salary = new Salary();
        public SalaryExecutingForm()
        {
            InitializeComponent();
        }

        private void exe_execute_Click(object sender, EventArgs e)
        {
            salary.IDTEACHER = exe_idtch.Text;
            salary.Month = int.Parse(exe_month.Text);
            salary.Year = int.Parse(exe_year.Text);

            try
            {
                if (salaryBL.salaryExecute(salary) != 0)
                {
                    salary.Total = salaryBL.salaryExecute(salary);
                    MessageBox.Show("Total salary: " + salary.Total, "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salaryBL.solveSalaryReport(salary);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Executing failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exe_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryExecutingForm_Load(object sender, EventArgs e)
        {
            exe_idtch.Focus();
        }
    }
}
