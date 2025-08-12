using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DL
{
    public class AccountDL : DataAccess
    {
        public void AddStudentAccount(Account acc)
        {
            string procedureName = "AddStudentAccount";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDS",acc.Username),
                new SqlParameter("@USERNAME",acc.Username),
                new SqlParameter("@Passwords",acc.Password),
                new SqlParameter("@DisplayName",acc.DisplayName),
                new SqlParameter("@ROLES","Student"),
                new SqlParameter("@IDUSER",acc.Iduser)

            };
            ExecuteNonQuery(procedureName, parameters);
        }

        public bool StudentAccountExists(string studentID)
        {
            if (string.IsNullOrEmpty(studentID))
            {
                throw new ArgumentException("studentID không được để trống.");
            }

            string procedureName = "CheckStudentAccountExist";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@USERNAME", studentID) // Đảm bảo tham số này đúng
            };

            Console.WriteLine($"Checking account existence for username: {studentID}");

            object result = ExecuteScalar(procedureName, parameters);
            int accountCount = result != null ? Convert.ToInt32(result) : 0;
            return accountCount > 0; // Kiểm tra nếu có tài khoản hay không
        }
        public int TotalAccount()
        {
            string produreName = "GetTotalAccount";

            return (int)ExecuteScalar(produreName, null);
        }
        public int TotalStudentAccount()
        {
            string produreName = "GetTotalStudentAccount";

            return (int)ExecuteScalar(produreName, null);
        }
        public int GetMaxUserId()
        {
            string procedureName = "GetMaxUserID";

            return (int)ExecuteScalar(procedureName, null);
        }
    }
}
