using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DL
{
    public class ClassDL : DataAccess
    {
        public Class GetClassDetail(int idClass)
        {
            string query = "SELECT * FROM CLASS WHERE IDCLASS = @idClass";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idClass",idClass)
            };

            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    return new Class
                    {
                        IDClass = reader.GetString(reader.GetOrdinal("IDCLASS")),
                        Name = reader.GetString(reader.GetOrdinal("CLASSNAME")),
                        numberOfStudent = reader.GetInt32(reader.GetOrdinal("NUMBEROFSTUDENT")),
                        startDate = reader.GetDateTime(reader.GetOrdinal("STARTDATE")),
                        endDate = reader.GetDateTime(reader.GetOrdinal("ENDDATE")),
                        IDTeacher = reader.GetString(reader.GetOrdinal("IDTEACHER")),
                        CaHoc = reader.GetInt32(reader.GetOrdinal("CAHOC")),
                        Room = reader.GetInt32(reader.GetOrdinal("ROOM")),
                        Timetable = reader.GetString(reader.GetOrdinal("TIMETABLE")),
                    };
                }
            }
            return null;
        }
        public DataTable GetAllClasses()
        {
            string procedureName = "GetListOfClass";
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }
        public void AddClass(Class classes)
        {
            string procedureName = "AddClassDetail";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCLASS",classes.IDClass),
                new SqlParameter("@CLASSNAME",classes.Name),
                new SqlParameter("@NUMBEROFSTUDENT",classes.numberOfStudent),
                new SqlParameter("@STARTDATE",classes.startDate),
                new SqlParameter("@ENDDATE",classes.endDate),
                new SqlParameter("@IDTEACHER",classes.IDTeacher),
                new SqlParameter("@CAHOC",classes.CaHoc),
                new SqlParameter("@STATES",classes.States),
                new SqlParameter("@ROOM",classes.Room),
                new SqlParameter("@TIMETABLE",classes.Timetable)
            };
            ExecuteNonQuery(procedureName, parameters);
        }
        public int GetClassCount()
        {
            if(conn.State== ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string total = "SELECT COUNT(*) FROM CLASS";
                    using (SqlCommand cmd = new SqlCommand(total, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        return table.Rows.Count;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return 0;
        }
        public int GetActiveClassCount()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string total = "SELECT IDCLASS FROM CLASS WHERE STATES =N'Đang Hoạt Động'";
                    using (SqlCommand cmd =  new SqlCommand(total, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        return table.Rows.Count;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return 0;
        }
        public int GetInactiveClassCount()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string total = "SELECT COUNT(*) AS TotalInactiveClass FROM CLASSWHERE STATES =N'Đã Kết Thúc'";
                    using (SqlCommand cmd = new SqlCommand(total, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        return table.Rows.Count;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return 0;
        }
        public void UpdateClass(Class classes)
        {
            string procedureName = "UpdateClassDetail";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCLASS",classes.IDClass),
                new SqlParameter("@CLASSNAME",classes.Name),
                new SqlParameter("@NUMBEROFSTUDENT",classes.numberOfStudent),
                new SqlParameter("@STARTDATE",classes.startDate),
                new SqlParameter("@ENDDATE",classes.endDate),
                new SqlParameter("@IDTEACHER",classes.IDTeacher),
                new SqlParameter("@CAHOC",classes.CaHoc),
                new SqlParameter("@STATES",classes.States),
                new SqlParameter("@ROOM",classes.Room),
                new SqlParameter("@TIMETABLE",classes.Timetable)
            };
            ExecuteNonQuery(procedureName, parameters);
        }
        public void DeleteClassDetail(string idClass)
        {
            string procedureName = "DeleteClassDetail";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCLASS",idClass)
            };
            ExecuteNonQuery(procedureName, parameters);
        }
        public int ChecKClassExist(string idClass)
        {
            string procedureName = "CheckExistClass";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCLASS",idClass)
            };
            return (int)ExecuteScalar(procedureName, parameters);
        }
    }
}
