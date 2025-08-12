using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public class AccountBL
    {
        private AccountDL accountDL = new AccountDL();
        public void AddStudentAccount(Account acc)
        {

            accountDL.AddStudentAccount(acc);
        }
        public bool StudentAccountExists(string studentID)
        {
            return accountDL.StudentAccountExists(studentID);
        }
        public int GetTotalAccount()
        {
            return accountDL.TotalAccount();
        }
        public int GetTotalStudentAccount()
        {
            return accountDL.TotalStudentAccount();
        }
        public int GetMaxUserId()
        {
            return accountDL.GetMaxUserId();
        }
    }
}
