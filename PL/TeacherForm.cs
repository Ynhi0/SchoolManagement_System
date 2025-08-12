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
    public partial class TeacherForm : Form
    {
        private TeacherBL teacherBL = new TeacherBL();
        Teacher teacher = new Teacher();
        private SalaryBL salaryBL = new SalaryBL();
        Salary salaryInfo = new Salary();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void tch_return_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeacherInfo();
            salary_tch.Parent = this;
            tchslr_slrif.DataSource = salaryBL.workingDetails();
        }

        private void LoadTeacherInfo()
        {
            tchinfo_total.Text = teacherBL.totalTeacher().ToString();
            tchinfo_working.Text = teacherBL.workingTeacher().ToString();
            TeacherInfo.DataSource = teacherBL.getTeacher();
            AddButton();
        }

        private DataGridViewImageColumn CustomImageColumn(string imgName)
        {
            string appPath = Application.StartupPath;
            var imgFolder = appPath.Remove(appPath.IndexOf("\\bin\\Debug"));

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Image = Image.FromFile(imgFolder + "\\Images\\" + imgName);
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            return imgCol;
        }

        private void AddButton()
        {
            if (!TeacherInfo.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn editCol = CustomImageColumn("Edit.png");
                editCol.Name = "Edit";
                editCol.HeaderText = "Edit";
                TeacherInfo.Columns.Add(editCol);
            }
        }

        private void tch_add_Click(object sender, EventArgs e)
        {
            AddTeacherForm addtch = new AddTeacherForm();

            if (addtch.ShowDialog() == DialogResult.OK)
            {
                LoadTeacherInfo();
            }
        }

        private void TeacherInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TeacherInfo.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                teacher.IDTEACHER = TeacherInfo.Rows[e.RowIndex].Cells["IDTEACHER"].Value.ToString();
                teacher.NAMEOFTEACHER = TeacherInfo.Rows[e.RowIndex].Cells["NAMEOFTEACHER"].Value.ToString();
                teacher.BORNDATE = TeacherInfo.Rows[e.RowIndex].Cells["BORNDATE"].Value.ToString();
                teacher.GENDER = TeacherInfo.Rows[e.RowIndex].Cells["GENDER"].Value.ToString();
                teacher.ADDRESSOFTEACHER = TeacherInfo.Rows[e.RowIndex].Cells["ADDRESSOFTEACHER"].Value.ToString();
                teacher.SALARY = int.Parse(TeacherInfo.Rows[e.RowIndex].Cells["SALARY"].Value.ToString() ?? string.Empty);
                teacher.PHONE = TeacherInfo.Rows[e.RowIndex].Cells["PHONE"].Value.ToString();
                teacher.STATUS = TeacherInfo.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
                teacher.SALARYCOEFFICIENT = decimal.Parse(TeacherInfo.Rows[e.RowIndex].Cells["SALARYCOEFFICIENT"].Value.ToString() ?? string.Empty);

                TeacherInfoUpdate updtchfrm = new TeacherInfoUpdate();
                updtchfrm.SetTeacher(teacher);

                if (updtchfrm.ShowDialog() == DialogResult.OK)
                {
                    LoadTeacherInfo();
                }
            }
        }

        private void tch_search_TextChanged(object sender, EventArgs e)
        {
            string filtertext = tch_search.Text;
            DataTable filter = teacherBL.searchTeacher(filtertext);
            if (string.IsNullOrEmpty(tch_search.Text))
            {
                TeacherInfo.DataSource = teacherBL.getTeacher();
            }
            else
            {
                TeacherInfo.DataSource = filter;
            }
        }

        private void tch_info_Click(object sender, EventArgs e)
        {
            info_tch.Show();
            salary_tch.Hide();
        }

        private void salary_Click(object sender, EventArgs e)
        {
            ButtonsForSalary();
            salary_tch.Location = new Point(297, 43);
            salary_tch.Show();
            info_tch.Hide();
        }

        private void tchslr_add_Click(object sender, EventArgs e)
        {
            SalaryAddForm slrfrm = new SalaryAddForm();

            if (slrfrm.ShowDialog() == DialogResult.OK)
            {
                tchslr_slrif.DataSource = salaryBL.workingDetails();
            }
        }

        private void tchslr_add_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonsForSalary()
        {
            if (!tchslr_slrif.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn editCol = CustomImageColumn("Edit.png");
                editCol.Name = "Edit";
                editCol.HeaderText = "Edit";
                tchslr_slrif.Columns.Add(editCol);
            }
        }

        private void tchslr_slrif_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tchslr_slrif.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                salaryInfo.ID = tchslr_slrif.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                salaryInfo.IDTEACHER = tchslr_slrif.Rows[e.RowIndex].Cells["IDTEACHER"].Value.ToString();
                salaryInfo.Month = int.Parse(tchslr_slrif.Rows[e.RowIndex].Cells["Month"].Value.ToString() ?? string.Empty);
                salaryInfo.Year = int.Parse(tchslr_slrif.Rows[e.RowIndex].Cells["Year"].Value.ToString() ?? string.Empty);
                salaryInfo.WorkingHours = int.Parse(tchslr_slrif.Rows[e.RowIndex].Cells["WorkingHours"].Value.ToString() ?? string.Empty);
                salaryInfo.Status = tchslr_slrif.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                SalaryInfo slrfrm = new SalaryInfo();
                slrfrm.ReportDetails(salaryInfo);

                if (slrfrm.ShowDialog() == DialogResult.OK)
                {
                    tchslr_slrif.DataSource = salaryBL.workingDetails();
                }
            }
        }

        private void tchslr_exc_Click(object sender, EventArgs e)
        {
            SalaryExecutingForm exefrm = new SalaryExecutingForm();

            if (exefrm.ShowDialog() == DialogResult.OK)
            {
                tchslr_slrif.DataSource = salaryBL.workingDetails();
            }
        }

        private void tchslr_search_TextChanged(object sender, EventArgs e)
        {
            string filtertext = tchslr_search.Text.Trim();
            DataTable filter = salaryBL.searching(filtertext);

            if (string.IsNullOrEmpty(tchslr_search.Text))
            {
                tchslr_slrif.DataSource = salaryBL.workingDetails();
            }
            else
            {
                tchslr_slrif.DataSource = filter;
            }
        }

        private void tchslr_month_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tchslr_month_TextChanged(object sender, EventArgs e)
        {
            salaryInfo.Month = tchslr_month.SelectedIndex;
            DataTable filter = salaryBL.searchingByMonth(salaryInfo);

            if (string.IsNullOrEmpty(tchslr_month.Text.ToString()))
            {
                tchslr_slrif.DataSource = salaryBL.workingDetails();
            }
            else
            {
                tchslr_slrif.DataSource = filter;
            }
        }

        private void tchslr_year_TextChanged(object sender, EventArgs e)
        {
            salaryInfo.Year = tchslr_year.SelectedIndex;
            DataTable filter = salaryBL.searchingByYear(salaryInfo);

            if (string.IsNullOrEmpty(tchslr_year.Text.ToString()))
            {
                tchslr_slrif.DataSource = salaryBL.workingDetails();
            }
            else
            {
                tchslr_slrif.DataSource = filter;
            }
        }
    }
}
