using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInClass.Models
{
    public class UserNameException : Exception
    {
        public UserNameException()
        {

        }
        public UserNameException(string message) : base(message)
        {

        }
        public override string Message => "Username is not in correct format";
    }
}
