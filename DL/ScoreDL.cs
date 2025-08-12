using DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class ScoreDL : DataAccess
    {
        public DataTable GetAllStudentScore()
        {
            string procedureName = "StudentScoreDetails";
            DataTable dataTable = new DataTable();

            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }
        public void UpdateStudentScore(Score score)
        {
            string procedureName = "EditStudentScore";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDSTU",score.studentID),
                new SqlParameter("@IDCLASS",score.IdClass),
               // new SqlParameter("@NAMESTUDENT",score.name),
                new SqlParameter("@LISTENSCORED",score.listenScore),
                new SqlParameter("@READSCORED",score.readScore),
                new SqlParameter("@SPEAKSCORED",score.speakScore),
                new SqlParameter("@WRITESCORED",score.writeScore),
                new SqlParameter("@TOTALSCORE",score.totalScore)
            };
            ExecuteNonQuery(procedureName, parameters);
        }

    }
}
