using DL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LoginBL
    {
        private LoginDL loginDL = new LoginDL();

        public bool LoginValidation(Users user)
        {
            if(string.IsNullOrEmpty(user.USERNAME) || string.IsNullOrEmpty(user.Passwords))
            {
                return false;
            }
            else
            {
                return loginDL.checkLogin(user);
            }
        }
    }
}
