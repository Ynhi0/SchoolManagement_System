using DTO;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DL
{
    public class StudentDL : DataAccess
    {
        public Student GetStudentDetails(string idUser)
        {
            string query = @"
                SELECT *
                FROM STUDENTINFOR si
                INNER JOIN STUDENT s ON si.IDS = s.IDS
                WHERE s.IDUSER = @idUser";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idUser", idUser)
            };

            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    return new Student
                    {
                        IDS = reader.GetString(reader.GetOrdinal("IDS")),
                        Name = reader.GetString(reader.GetOrdinal("NAMESTUDENT")),
                        Gender = reader.GetString(reader.GetOrdinal("GENDER")),
                        BornDate = reader.GetDateTime(reader.GetOrdinal("BORNDATE")),
                        IDClass = reader.GetString(reader.GetOrdinal("IDCLASS")),
                        States = reader.GetString(reader.GetOrdinal("STATES"))
                    };
                }
            }

            return null; // Return null if no student is found
        }
        public Student GetStudentDetailByID(string studentID)
        {
            string query = @" SELECT * FROM STUDENTINFOR WHERE IDS =@studentID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentID", studentID)
            };

            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    return new Student
                    {
                        IDS = reader.GetString(reader.GetOrdinal("IDS")),
                        Name = reader.GetString(reader.GetOrdinal("NAMESTUDENT")),
                        Gender = reader.GetString(reader.GetOrdinal("GENDER")),
                        BornDate = reader.GetDateTime(reader.GetOrdinal("BORNDATE")),
                        IDClass = reader.GetString(reader.GetOrdinal("IDCLASS")),
                        States = reader.GetString(reader.GetOrdinal("STATES"))
                    };
                }
            }

            return null; // Return null if no student is found
        }

        public DataTable GetAllStudents()
        {
            string query = "GetStudentDetails";
            DataTable dataTable = new DataTable();

            using (SqlDataReader reader = ExecuteReader(query, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }
        public DataTable GetAllStudentFee()
        {
            string procedureName = "GetStudentFee";
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }
        public void AddStudent(Student student)
        {
            string query = "AddStudentsInfor";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDS",student.IDS),
                new SqlParameter("@IDCLASS", student.IDClass),
                new SqlParameter("@NAMESTUDENT", student.Name),
                new SqlParameter("@GENDER", student.Gender),
                new SqlParameter("@BORNDATE", student.BornDate),
                new SqlParameter("@STATES", student.States)
            };
            ExecuteNonQuery(query, parameters);
        }
        public void AddStudentFee(Student student)
        {
            string procedureName = "AddStudentFee";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDS",student.IDS),
                new SqlParameter("@TUITIONFEE", student.TuitionFee),
                new SqlParameter("@DUEDATE", student.DueDate),
                new SqlParameter("@MONTH", student.Month),
                new SqlParameter("@STATES", student.States)
            };
            ExecuteNonQuery(procedureName, parameters);
        }

        public int GetTotalStudents()
        {
            string produreName = "GetTotalStudents";

            return (int)ExecuteScalar(produreName, null);
        }
        public int GetTotalFemaleStudent()
        {
            string procedureName = "GetTotalFemaleStudent";
            return (int)ExecuteScalar(procedureName, null);
        }
        public int GetTotalMaleStudent()
        {
            string procedureName = "GetTotalMaleStudent";
            return (int)ExecuteScalar(procedureName, null);
            ;
        }

        public int GetTotalOnlStudents()
        {
            string produreName = "StateOfOnlStudent";
            return (int)ExecuteScalar(produreName, null);
        }

        public int GetTotalOffStudents()
        {
            string proredureName = "StateofOFFStudent";
            return (int)ExecuteScalar(proredureName, null);
        }
        public void UpdateStudent(Student student)
        {
            string procedureName = "UpdateStudentsInfor";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDS",student.IDS),
                new SqlParameter("@NAMESTUDENT", student.Name),
                new SqlParameter("@GENDER", student.Gender),
                new SqlParameter("@BORNDATE", student.BornDate),
                new SqlParameter("@IDCLASS", student.IDClass),
                new SqlParameter("@STATES", student.States)
            };
            ExecuteNonQuery(procedureName, parameters);
        }
        public void UpdateStudentFee(Student student)
        {
            string produreName = "EditStudentFee";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDS",student.IDS),
                new SqlParameter("@TUITIONFEE", student.TuitionFee),
                new SqlParameter("@DUEDATE", student.DueDate),
                new SqlParameter("@MONTHS", student.Month),
                new SqlParameter("@STATE", student.States)
            };
            ExecuteNonQuery(produreName, parameters);
        }
        public DataTable GetStudentAccount()
        {
            string procedureName = "GetStudentAccount";
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void DeleteStudent(string studentId)
        {
            string procedureName = "DeleteStudentInfor";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StudentID",studentId)
            };
            ExecuteNonQuery(procedureName, parameters);
        }

        public void DeleteStudentAccount(string studentId)
        {
            string procedureName = "DeleteStudentAccount";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StudentID",studentId)
            };
            ExecuteNonQuery(procedureName, parameters);
        }

        public int CountPassStudent()
        {
            string procedureName = "CountPassedStudents";
            return (int)ExecuteScalar(procedureName, null);
        }
        public int CountFailStudent()
        {
            string procedureName = "CountFailedStudents";
            return (int)ExecuteScalar(procedureName, null);
        }
        public string GetStudentState(string idStudent)
        {
            string procedureName = "GetStudentState";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StudentID",idStudent)
            };
            return ExecuteScalar(procedureName, parameters).ToString();
        }
        public int CheckIdStudent(string IDs)
        {
            string procedureName = "CheckIfStudentIDexist";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDSTUDENT",IDs)
            };
            return (int)ExecuteScalar(procedureName, parameters);
        }

    }

}


