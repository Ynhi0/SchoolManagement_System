using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using DTO;

namespace DL
{
    public class TeacherDL:DataAccess
    {
        public DataTable GetTeacher()
        {
            SqlDataAdapter getTeacher = new SqlDataAdapter("SELECT * FROM TEACHERINFOR", conn);
            DataTable teacherInfo = new DataTable();
            getTeacher.Fill(teacherInfo);
            return teacherInfo;
        }

        public bool AddTeacher(Teacher teacher)
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string checkRole = "SELECT ROLE FROM USERS WHERE IDUSER = @iduser";
                    SqlCommand check = new SqlCommand(checkRole, conn);
                    check.Parameters.AddWithValue("@iduser", teacher.IDUSER);
                    string role = (string)check.ExecuteScalar();

                    if (role == "Teacher")
                    {
                        string addTeacher = "INSERT INTO TEACHERINFOR (IDTEACHER, NAMEOFTEACHER, BORNDATE, GENDER, ADDRESSOFTEACHER, SALARY, PHONE, STATUS, SALARYCOEFFICIENT) VALUES (@idtch, @nm, @brndate, @gender, @address, @slr, @phone, @sts, @slrcf)";
                        using (SqlCommand cmd = new SqlCommand(addTeacher, conn))
                        {
                            cmd.Parameters.AddWithValue("@idtch", teacher.IDTEACHER);
                            cmd.Parameters.AddWithValue("@nm", teacher.NAMEOFTEACHER);
                            cmd.Parameters.AddWithValue("@brndate", teacher.BORNDATE);
                            cmd.Parameters.AddWithValue("@gender", teacher.GENDER);
                            cmd.Parameters.AddWithValue("@address", teacher.ADDRESSOFTEACHER);
                            cmd.Parameters.AddWithValue("@slr", teacher.SALARY);
                            cmd.Parameters.AddWithValue("@phone", teacher.PHONE);
                            cmd.Parameters.AddWithValue("@sts", teacher.STATUS);
                            cmd.Parameters.AddWithValue("@slrcf", teacher.SALARYCOEFFICIENT);

                            cmd.ExecuteNonQuery();
                        }

                        string addIdteacher = "INSERT INTO TEACHER (IDUSER, IDTEACHER) VALUES (@iduser, @idtch)";
                        using (SqlCommand add = new SqlCommand(addIdteacher, conn))
                        {
                            add.Parameters.AddWithValue("@iduser", teacher.IDUSER);
                            add.Parameters.AddWithValue("@idtch", teacher.IDTEACHER);

                            add.ExecuteNonQuery();
                        }
                        return true;
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
            return false;
        }

        public bool UpdTeacher(Teacher teacher)
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string updTeacher = "UPDATE TEACHERINFOR SET NAMEOFTEACHER = @nm, BORNDATE = @brndate, GENDER = @gender, ADDRESSOFTEACHER = @address, SALARY = @slr, PHONE = @phone, STATUS = @sts, SALARYCOEFFICIENT = @slrcf WHERE IDTEACHER = @idtch";
                    using (SqlCommand cmd = new SqlCommand(updTeacher, conn))
                    {
                        cmd.Parameters.AddWithValue("@idtch", teacher.IDTEACHER);
                        cmd.Parameters.AddWithValue("@nm", teacher.NAMEOFTEACHER);
                        cmd.Parameters.AddWithValue("@brndate", teacher.BORNDATE);
                        cmd.Parameters.AddWithValue("@gender", teacher.GENDER);
                        cmd.Parameters.AddWithValue("@address", teacher.ADDRESSOFTEACHER);
                        cmd.Parameters.AddWithValue("@slr", teacher.SALARY);
                        cmd.Parameters.AddWithValue("@phone", teacher.PHONE);
                        cmd.Parameters.AddWithValue("@sts", teacher.STATUS);
                        cmd.Parameters.AddWithValue("@slrcf", teacher.SALARYCOEFFICIENT);

                        cmd.ExecuteNonQuery();
                    }
                    return true;
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
            return false;
        }
        
        public DataTable SearchTeacher(string filtertext)
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string searchTeacher = "SELECT * FROM TEACHERINFOR WHERE NAMEOFTEACHER LIKE @filtertext";
                    using (SqlCommand cmd = new SqlCommand(searchTeacher, conn))
                    {
                        cmd.Parameters.AddWithValue("filtertext", filtertext);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
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
            return table;
        }

        public int TotalTeacher()
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string totalTeacher = "SELECT IDTEACHER FROM TEACHERINFOR";
                    using (SqlCommand cmd = new SqlCommand(totalTeacher, conn))
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

        public int WorkingTeacher()
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string countTeacher = "SELECT IDTEACHER FROM TEACHERINFOR WHERE STATUS = N'Working'";
                    using (SqlCommand cmd = new SqlCommand(countTeacher, conn))
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
        ////////////////////////////////////////////////////////////
        public int GetTotalTeacher()
        {
            return (int)ExecuteScalar("GetTotalTeacher", null);
        }
        public int GetTotalFemaleTeacher()
        {
            return (int)ExecuteScalar("GetTotalFemaleTeacher", null);
        }
        public int GetTotalMaleTeacher()
        {
            return (int)ExecuteScalar("GetTotalMaleTeacher", null);
        }
        public string GetTeacherNameByID(string idTeacher)
        {
            return (string)ExecuteScalar("GetTeacherNameByID", new SqlParameter[]
            {
                new SqlParameter("@idTeacher",idTeacher)
            });
        }
        public DataTable getIdTeacherList()
        {
            string procedureName = "GetTeacherID";
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = ExecuteReader(procedureName, new SqlParameter[0]))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }
    }
}