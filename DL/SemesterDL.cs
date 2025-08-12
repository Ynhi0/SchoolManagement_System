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
    public class SemesterDL : DataAccess
    {
        public DataTable GetSemesterDetail()
        {
            string procedureName = "GetSemesterDetails";
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public bool AddSemesterDate(Semester semester)
        {
            try
            {
                string procedureName = "AddSemesterDate";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDCLASS", semester.IdClass),
                    new SqlParameter("@SPEAKINGTEST", semester.speakingTest),
                    new SqlParameter("@LISTENINGTEST", semester.listeningTest),
                    new SqlParameter("@READINGTEST", semester.readingTest),
                    new SqlParameter("@WRITINGTEST", semester.writingTest)
                };

                ExecuteNonQuery(procedureName, parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public DataTable GetActiveClass()
        {
            string procedureName = "GetActiveClass";
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }
        public string GetClassNameByID(string idClass)
        {
            string procedureName = "SELECT CLASSNAME FROM CLASS WHERE IDCLASS = @IDCLASS";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCLASS",idClass)
            };
            using (SqlDataReader reader = ExecuteReader(procedureName, parameters))
            {
                if (reader.Read())
                    return reader.GetString(reader.GetOrdinal("CLASSNAME"));
            }
            return null;
        }
        public void DeleteSemester(string IdClass)
        {
            string procedureName = "DeleteExamDate";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCLASS", IdClass)
            };

            ExecuteNonQuery(procedureName, parameters);
        }
        public void EditSemester(Semester semester)
        {
            string procedureName = "UpdateExamDate";
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@IDCLASS",semester.IdClass),
                new SqlParameter("SPEAKINGTEST", semester.speakingTest),
                new SqlParameter("@LISTENINGTEST", semester.listeningTest),
                new SqlParameter("@WRITINGTEST", semester.writingTest),
                new SqlParameter("@READINGTEST", semester.readingTest)

             };
            ExecuteNonQuery(procedureName, parameters);
        }
    } 
}
