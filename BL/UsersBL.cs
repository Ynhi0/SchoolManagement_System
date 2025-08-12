using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using DTO;

namespace BL
{
    public class UsersBL
    {
        UsersDL userDL = new UsersDL();
        public DataTable getUsers()
        {
            return userDL.GetUsers();
        }

        public bool addUser(Users user)
        {
            if (string.IsNullOrEmpty(user.USERNAME) || string.IsNullOrEmpty(user.Passwords) || userDL.CheckUser(user))
            {
                return false;
            }
            else
            {
                return userDL.AddUser(user);
            }
        }

        public bool updUser(Users user)
        {
            if (string.IsNullOrEmpty(user.USERNAME) || string.IsNullOrEmpty(user.Passwords)|| string.IsNullOrEmpty(user.ROLE))
            {
                return false;
            }
            else
            {
                return userDL.UpdateUser(user);
            }
        }

        public bool delUser(Users user)
        {
            {
                return userDL.DelUser(user);
            }
        }

        public DataTable searchUser(string filtertext)
        {
            return userDL.SearchUser(filtertext);
        }
    }
}
