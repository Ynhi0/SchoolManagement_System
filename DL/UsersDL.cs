using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DL
{
    public class UsersDL:DataAccess
    {
        AccountDL accountDL = new AccountDL();
        public DataTable GetUsers()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM USERS WHERE ROLE IN ('Teacher', 'Student')", conn);
            DataTable usersInfo = new DataTable();
            adapter.Fill(usersInfo);
            return usersInfo;
        }

        public bool AddUser(Users user)
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string addUser = "INSERT INTO USERS (IDUSER,USERNAME, Passwords, ROLE, DisplayName) VALUES (@id,@usern, @pass, @role, @displname)";
                    using (SqlCommand cmd = new SqlCommand(addUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@usern", user.USERNAME);
                        cmd.Parameters.AddWithValue("@pass", user.Passwords);
                        cmd.Parameters.AddWithValue("@role", user.ROLE);
                        cmd.Parameters.AddWithValue("@displname", user.DisplayName);
                        cmd.Parameters.AddWithValue("@id", user.IDUSER = accountDL.GetMaxUserId() +1);

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

        public bool CheckUser(Users user)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    string selectUser = "SELECT * FROM USERS WHERE USERNAME = @usern";
                    using (SqlCommand cmd = new SqlCommand(selectUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@usern", user.USERNAME);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if(table.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
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
            return false;
        }

        public bool UpdateUser(Users user)
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string updateData = "UPDATE USERS SET USERNAME = @usern, Passwords = @pass, ROLE = @role, DisplayName = @displname WHERE IDUSER = @id";
                    using (SqlCommand cmd = new SqlCommand(updateData, conn))
                    {
                        cmd.Parameters.AddWithValue("@usern", user.USERNAME);
                        cmd.Parameters.AddWithValue("@pass", user.Passwords);
                        cmd.Parameters.AddWithValue("@role", user.ROLE);
                        cmd.Parameters.AddWithValue("@id", user.IDUSER);
                        cmd.Parameters.AddWithValue("@displname", user.DisplayName);
                        
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

        public bool DelUser(Users user)
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string delAcc = "DELETE FROM USERS WHERE IDUSER = @id";
                    using (SqlCommand cmd = new SqlCommand(delAcc, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", user.IDUSER);

                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine (ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        public DataTable SearchUser(string filterText)
        {
            DataTable table = new DataTable();
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM USERS WHERE USERNAME LIKE @filtertext";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filtertext", filterText);

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
    }
}
