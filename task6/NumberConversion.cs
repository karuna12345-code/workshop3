using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class NumberConversion
    {
        public void Run()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine("The integer is: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }
    }
}
