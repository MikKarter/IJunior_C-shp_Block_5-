using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> vocabulary = new Dictionary<string, string>();
            vocabulary.Add("Word", "value");
            CheckingValueWords(vocabulary);
        }

        static void CheckingValueWords(Dictionary<string, string> vocabulary)
        {
            string userInput = Console.ReadLine();

            if (vocabulary.ContainsKey(userInput))
            {
                Console.WriteLine(vocabulary[userInput]);
            }

            else
            {
                Console.WriteLine("Wrong word, please try again");
            }
        }
    }
}
