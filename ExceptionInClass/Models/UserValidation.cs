using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInClass.Models
{
    public class UserValidation
    {
        public string ValidateLogInData(LoginInformation loginInformation)
        {
            if (!IsValidUserName(loginInformation.UserName))
            {
                throw new Exception("Username error");
            }
            if (!IsValidPassword(loginInformation.Password))
            {
                throw new Exception("Password error");
            }
            return "Login was succesfull";
        }
        private bool IsValidUserName(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            if (username.Length < 4 || username.Length > 20)
            {
                return false;
            }
            return true;
        }
        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length < 4 || password.Length > 20)
            {
                return false;
            }
            return true;
        }
    }
}
