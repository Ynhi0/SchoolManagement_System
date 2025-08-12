using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PL
{
    public partial class UpdateStudentScore : Form
    {
        private string studentID, classID;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Score UpdateScore = new Score
            {
                studentID = txtIDS.Text,
                name = txtName.Text,
                IdClass = txtClassID.Text,
                className = txtClassName.Text,
                writeScore = int.Parse(txtListening.Text),
                readScore = int.Parse(txtReading.Text),
                listenScore = int.Parse(txtListening.Text),
                speakScore = int.Parse(txtSpeaking.Text),
                totalScore = int.Parse(txtTotalName.Text)
            };
            ScoreBL scoreBL = new ScoreBL();
            scoreBL.UpdateStudentScore(UpdateScore);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Lưu thành công");
            this.Close();
        }
        private void UpdateTotalScore()
        {
            int listeningScore = int.TryParse(txtListening.Text, out var ls) ? ls : 0;
            int readingScore = int.TryParse(txtReading.Text, out var rs) ? rs : 0;
            int speakingScore = int.TryParse(txtSpeaking.Text, out var ss) ? ss : 0;
            int writingScore = int.TryParse(txtWriting.Text, out var ws) ? ws : 0;

            int totalScore = listeningScore + readingScore + speakingScore + writingScore;
            txtTotalName.Text = totalScore.ToString();
        }
        private void txtTotalName_TextChanged(object sender, EventArgs e)
        {

        }

        public UpdateStudentScore(string studentId, string name, string classId, string className, int writingScore,
        int readingScore, int listeningScore, int speakingscore, int totalScore)
        {
            InitializeComponent();
            studentID = studentId;
            classID = classId;
            txtClassID.Text = classID;
            txtClassID.ReadOnly = true;
            txtIDS.Text = studentID;
            txtIDS.ReadOnly = true;
            txtClassName.Text = className;
            txtClassName.ReadOnly = true;
            txtName.Text = name;
            txtName.ReadOnly = true;
            txtListening.Text = listeningScore.ToString();
            txtReading.Text = readingScore.ToString();
            txtWriting.Text = writingScore.ToString();
            txtSpeaking.Text = speakingscore.ToString();
            txtTotalName.Text = totalScore.ToString();
            txtTotalName.ReadOnly = true;

            //Đăng ký sự kiện
            txtListening.TextChanged += (s, e) => UpdateTotalScore();
            txtReading.TextChanged += (s, e) => UpdateTotalScore();
            txtWriting.TextChanged += (s, e) => UpdateTotalScore();
            txtSpeaking.TextChanged += (s, e) => UpdateTotalScore();
        }
    }
}
