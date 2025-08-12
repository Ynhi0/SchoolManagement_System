using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DL
{
    public class SalaryDL : DataAccess
    {
        public DataTable WorkingDetail()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM WORKING", conn);
            DataTable workingDetail = new DataTable();
            adapter.Fill(workingDetail);
            return workingDetail;
        }

        public bool AddSalaryDetails(Salary salary)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string adddetails = "INSERT INTO WORKING (ID, IDTEACHER, Month, Year, WorkingHours, Status) VALUES (@id, @idteacher, @month, @year, @workinghours, @sts)";
                    using (SqlCommand cmd = new SqlCommand(adddetails, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", salary.ID);
                        cmd.Parameters.AddWithValue("@idteacher", salary.IDTEACHER);
                        cmd.Parameters.AddWithValue("@month", salary.Month);
                        cmd.Parameters.AddWithValue("@year", salary.Year);
                        cmd.Parameters.AddWithValue("@workinghours", salary.WorkingHours);
                        cmd.Parameters.AddWithValue("@sts", salary.Status);

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

        public bool UpdSalaryDetails(Salary salary)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string updSalary = "UPDATE WORKING SET IDTEACHER = @idtch, Month = @month, Year = @year, WorkingHours = @wrkhrs, Status = @sts WHERE ID = @id";
                    using (SqlCommand cmd = new SqlCommand(updSalary, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", salary.ID);
                        cmd.Parameters.AddWithValue("@idtch", salary.IDTEACHER);
                        cmd.Parameters.AddWithValue("@month", salary.Month);
                        cmd.Parameters.AddWithValue("@year", salary.Year);
                        cmd.Parameters.AddWithValue("@wrkhrs", salary.WorkingHours);
                        cmd.Parameters.AddWithValue("@sts", salary.Status);

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

        public int SalaryExecute(Salary salary)
        {
            int total = 0;
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string salaryExecute = "SELECT ((t.SALARY * t.SALARYCOEFFICIENT) + (50000 * w.WorkingHours)) AS TongLuong FROM TEACHERINFOR t, WORKING w WHERE t.IDTEACHER = w.IDTEACHER AND t.IDTEACHER = @idtch AND w.Month = @month AND w.Year = @year";
                    using (SqlCommand cmd = new SqlCommand(salaryExecute, conn))
                    {
                        cmd.Parameters.AddWithValue("@idtch", salary.IDTEACHER);
                        cmd.Parameters.AddWithValue("@month", salary.Month);
                        cmd.Parameters.AddWithValue("@year", salary.Year);

                        object queryResult = cmd.ExecuteScalar();

                        if (queryResult != null)
                        {
                            total = Convert.ToInt32(queryResult);
                        }
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
            return total;
        }

        public DataTable Searching(string filtertext)
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string searching = "SELECT * FROM WORKING WHERE ID LIKE @filtertext";
                    using (SqlCommand cmd = new SqlCommand(searching, conn))
                    {
                        cmd.Parameters.AddWithValue("@filtertext", filtertext);

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

        public DataTable SearchingByMonth(Salary salary)
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string searching = "SELECT * FROM WORKING WHERE Month = @month + 1";
                    using (SqlCommand cmd = new SqlCommand(searching, conn))
                    {
                        cmd.Parameters.AddWithValue("@month", salary.Month);

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

        public DataTable SearchingByYear(Salary salary)
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string searching = "SELECT * FROM WORKING WHERE Year = @year + 1";
                    using (SqlCommand cmd = new SqlCommand(searching, conn))
                    {
                        cmd.Parameters.AddWithValue("@year", salary.Year);

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

        public bool SolveSalaryReport(Salary salary)
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string checkStatus = "UPDATE WORKING SET Status = @sts WHERE IDTEACHER = @idtch AND Month = @month AND Year = @year";
                    using (SqlCommand cmd = new SqlCommand(checkStatus, conn))
                    {
                        cmd.Parameters.AddWithValue("@idtch", salary.IDTEACHER);
                        cmd.Parameters.AddWithValue("@month", salary.Month);
                        cmd.Parameters.AddWithValue("@year", salary.Year);
                        cmd.Parameters.AddWithValue("sts", "Solved");

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
    }
}