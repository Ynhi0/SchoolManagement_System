using DL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ScoreBL
    {
        private ScoreDL scoreDL;
        public ScoreBL()
        {
            scoreDL = new ScoreDL();
        }
        public DataTable GetStudentScore()
        {
            return scoreDL.GetAllStudentScore();
        }
        public void UpdateStudentScore(Score score)
        {
            scoreDL.UpdateStudentScore(score);
        }
    }
}
