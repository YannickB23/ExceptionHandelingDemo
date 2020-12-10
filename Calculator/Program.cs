using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static int firstNumber;
        static int secondNumber;
        static int result = 0;
        static char operatorChar;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pls enter 1st number:");
                firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Pls enter 2nd nubmer:");
                secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Pls select the operation to be performed('+' , '-', '*', '/')");
                operatorChar = char.Parse(Console.ReadLine());
                switch (operatorChar)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        break;
                    case '/':
                        result = firstNumber / secondNumber;
                        break;

                    default:
                        break;
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("Your input was not integer");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("This is outside the range of Integers values");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine($"{firstNumber} {operatorChar} {secondNumber} = {result}");
            }
        }
    }
}
