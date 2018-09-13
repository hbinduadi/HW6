using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQuot
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Random rnd = new Random();
                decimal firstNum, secondNum, prod;
                decimal quot;
                for(int counter = 1; counter <= 10; counter++)
                {
                    firstNum = rnd.Next(0, 11);
                    secondNum = rnd.Next(0, 11);
                    prod = firstNum * secondNum;
                    quot = firstNum/secondNum;
                    //decimal Quotient = .ToString("#.00");
                    Console.WriteLine("Iteration : " + counter);
                    Console.WriteLine("The Product of " + firstNum + "*" + secondNum + " = " + prod);
                    Console.WriteLine("The quotient of " + firstNum + "/" + secondNum + " = " + quot.ToString("0.00"));
                    Console.WriteLine();

                }
            }

            catch (DivideByZeroException dzEx)
            {
                Console.WriteLine("Divide By Zero Exception Caught!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception Thrown " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    
}
