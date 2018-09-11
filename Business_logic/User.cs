using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    abstract class User
    {
        public String Login { get; private set; }
        private String password;

        public User (String login, String password)
        {
            Login = login;
            this.password = password;
        }


        public bool ChangePassword (String oldPassword, String newPassword)
        {
            if (oldPassword != newPassword && oldPassword == password)
            {
                password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LogIn (String password)
        {
            return (this.password == password);
        }
    }
}
