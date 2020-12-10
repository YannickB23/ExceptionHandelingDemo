using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInClass.Models
{
    public class PasswordException : Exception
    {
        public PasswordException()
        {

        }
        public PasswordException(string message) : base(message)
        {

        }
        public override string Message => "Password is not in correct format";
    }
}
