using ExceptionInClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInClass  //Custom Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter username:  ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:  ");
            string password = Console.ReadLine();
            LoginInformation loginInformation = new LoginInformation()
            {
                UserName = username,
                Password = password,
            };
            try
            {
            string result = userValidation.ValidateLogInData(loginInformation);
            Console.WriteLine(result);
            }
            catch (UserNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
