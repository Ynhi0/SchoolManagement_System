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
    public partial class ClassManagement : Form
    {
        private ClassBL classBL = new ClassBL();
        public ClassManagement()
        {
            InitializeComponent();
        }
        private void LoadListOfClass()
        {
            try
            {
                var classes = classBL.GetAllClass();
                dataGridViewClass.DataSource = classes;
                lblOffClass.Text = classBL.GetInactiveClassCount().ToString();
                lblOnlClass.Text = classBL.GetActiveClassCount().ToString();
                lblTotalClass.Text = classBL.GetClassCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading class data:" + ex.Message);
            }
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            LoadListOfClass();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void btnEnrollClass_Click(object sender, EventArgs e)
        {
            this.Close();
            EnrollClassManagement enrollClassManagement = new EnrollClassManagement();
            enrollClassManagement.ShowDialog();
        }

        private void btnExamSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassExamSchedule classExamSchedule = new ClassExamSchedule();
            classExamSchedule.ShowDialog();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassTimeTable classTimeTable = new ClassTimeTable();
            classTimeTable.ShowDialog();
        }

        private void lblTotalClass_Click(object sender, EventArgs e)
        {

        }

        private void lblOnlClass_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
