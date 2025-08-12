using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DL
{
    public class DataAccess
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R4AE29TT\SQLEXPRESS;Initial Catalog=SCHOOLDATABASES;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public void Connect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Disconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                Connect();

                try
                {
                    return cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Disconnect();
                }
                return null;
            }
        }
        public SqlDataReader ExecuteReader(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            Connect();
            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            Connect();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
