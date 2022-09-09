using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Тфыл_3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            List<int> numbers = new List<int>();
            GetNumber(ref numbers);
        }

        static void GetNumber(ref List<int> numbers)
        {
            bool isWork = true;  

            while (isWork)
            {     
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int resaultParse);

                if (resaultParse != 0)
                {
                    numbers.Add(resaultParse);
                }
                else if (userInput == "sum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (userInput == "exit")
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Input error. Please, input sum or exit for actions:");
                }
            }
        }
    }
}
