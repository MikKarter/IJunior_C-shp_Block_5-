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

            ProcessCommand(numbers);
        }

        static void ProcessCommand(List<int> numbers)
        {
            bool isWork = true;

            while (isWork)
            {
                string userInput = Console.ReadLine();
                string exit = "exit";
                string sum = "sum";

                if (int.TryParse(userInput, out int resaultParse) != false)
                {

                    numbers.Add(resaultParse);
                }
                else if (userInput == sum)
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (userInput == exit)
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
