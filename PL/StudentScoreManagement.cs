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
    public partial class StudentScoreManagement : Form
    {
        private StudentBL studentBL = new StudentBL();
        private ScoreBL scoreBL = new ScoreBL();
        public StudentScoreManagement()
        {
            InitializeComponent();
        }

        private void LoadStudentScore()
        {
            try
            {
                var studentScore = scoreBL.GetStudentScore();
                dataGridViewStudentsScore.DataSource = studentScore;
                AddButtonColumnsToDataGridView();
                lblFailedStudent.Text = studentBL.CountFailedStudent().ToString();
                lblTotalPassStudent.Text = studentBL.CountPassedStudent().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student's score data:" + ex.Message);
            }
        }

        private void StudentScoreManagement_Load(object sender, EventArgs e)
        {
            LoadStudentScore();
        }
        private DataGridViewImageColumn SetUpImageColumn(string imgName)
        {
            string appPath = Application.StartupPath;
            var imgFolder = appPath.Remove(appPath.IndexOf("\\bin\\Debug"));

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Image = Image.FromFile(imgFolder + "\\Images\\" + imgName);
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            return imgColumn;
        }


        private void AddButtonColumnsToDataGridView()
        {
            if (!dataGridViewStudentsScore.Columns.Contains("Edit"))
            {
                DataGridViewImageColumn imageColumnEdit = SetUpImageColumn("Edit.png");
                imageColumnEdit.Name = "Edit";
                imageColumnEdit.HeaderText = "Edit";
                dataGridViewStudentsScore.Columns.Add(imageColumnEdit);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudentsScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewStudentsScore.Columns[e.ColumnIndex].Name == "Edit")
            {
                var studentID = dataGridViewStudentsScore.Rows[e.RowIndex].Cells["IDSTU"].Value.ToString();
                var name = dataGridViewStudentsScore.Rows[e.RowIndex].Cells["NAMESTUDENT"].Value.ToString();
                var idClass = dataGridViewStudentsScore.Rows[e.RowIndex].Cells["IDCLASS"].Value.ToString();
                var className = dataGridViewStudentsScore.Rows[e.RowIndex].Cells["CLASSNAME"].Value.ToString();
                var listeningScore = int.Parse(dataGridViewStudentsScore.Rows[e.RowIndex].Cells["LISTENSCORED"].Value.ToString() ?? string.Empty);
                var readingScore = int.Parse(dataGridViewStudentsScore.Rows[e.RowIndex].Cells["READSCORED"].Value.ToString() ?? string.Empty);
                var writingScore = int.Parse(dataGridViewStudentsScore.Rows[e.RowIndex].Cells["WRITESCORED"].Value.ToString() ?? string.Empty);
                var speakingScore = int.Parse(dataGridViewStudentsScore.Rows[e.RowIndex].Cells["SPEAKSCORED"].Value.ToString() ?? string.Empty);
                var totalScore = int.Parse(dataGridViewStudentsScore.Rows[e.RowIndex].Cells["TOTALSCORED"].Value.ToString() ?? string.Empty);

                UpdateStudentScore updateStudentScore = new UpdateStudentScore(studentID, name, idClass, className, writingScore, readingScore, listeningScore, speakingScore, totalScore);
                if (updateStudentScore.ShowDialog() == DialogResult.OK)
                {
                    LoadStudentScore();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            this.Close();
            adminForm.Show();
        }

        private void btnStudentAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentAccountManangement studentAccountManangement = new StudentAccountManangement();
            studentAccountManangement.Show();
        }

        private void btnStudentInfor_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Show();
        }
        private void btnStudentScore_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            IncomeManagement incomeManagement = new IncomeManagement();
            incomeManagement.ShowDialog();
        }
    }
}
