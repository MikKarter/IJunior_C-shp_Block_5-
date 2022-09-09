using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            List<string> dossier = new List<string>();
            List<string> position = new List<string>();

            while (isWork)
            {
                Console.WriteLine("Введите номер команды");
                Console.WriteLine("1 - Добавить досье");
                Console.WriteLine("2 - Показать все досье");
                Console.WriteLine("3 - Удалить выбранное досье");
                Console.WriteLine("4 - Выход из программы");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddDossier(ref dossier, ref position);
                        break;
                    case "2":
                        ShowDossier(dossier, position);
                        break;
                    case "3":
                        DeleteDossier(ref dossier, ref position);
                        break;
                    case "4":
                        isWork = !isWork;
                        break;
                }
            }
        }
        static void AddDossier(ref List<string> dossier, ref List<string> position)
        {
            Console.WriteLine("FullName");
            string userInput = Console.ReadLine();
            dossier.Add(userInput);
            Console.WriteLine("Position");
            userInput = Console.ReadLine();
            position.Add(userInput);
        }

        static void DeleteDossier(ref List<string> dossier, ref List<string> position)
        {
            Console.WriteLine("Number of dossier");
            int userInput = Convert.ToInt32(Console.ReadLine());
            dossier.RemoveAt(userInput-1);
            position.RemoveAt(userInput-1);

        }

        static void ShowDossier(List<string> dossier, List<string> position)
        {
            for (int i = 0; i < dossier.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + dossier[i] + " " + position[i]);
            }
        }

    }
}
