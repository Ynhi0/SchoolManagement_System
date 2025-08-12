using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DL
{
    public class LoginDL:DataAccess
    {
        public bool checkLogin(Users user)
        {
            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string checkAcc = @"SELECT * FROM   USERS 
                                        WHERE  USERNAME = @usern
                                        AND Passwords = @pass ";
                    using (SqlCommand cmd = new SqlCommand(checkAcc, conn))
                    {
                        cmd.Parameters.AddWithValue("@usern", user.USERNAME);
                        cmd.Parameters.AddWithValue("@pass", user.Passwords);
                        cmd.Parameters.AddWithValue("@role", "Admin");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            return true;
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
    }
}
