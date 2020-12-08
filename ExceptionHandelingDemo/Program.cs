using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int firstNmbr = 0;
            int secNmbr = 0;

            try
            {
                Console.WriteLine("File log is open for writing");
                Console.WriteLine("Enter first nmbr");
                firstNmbr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second nmbr");
                secNmbr = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.Source);
                Console.WriteLine("*****There went something wrong:\n");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("File log is closed");
            }

            result = firstNmbr + secNmbr;
            Console.WriteLine(result);
        }
    }
}
