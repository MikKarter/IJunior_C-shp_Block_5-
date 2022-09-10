using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countAllPurchase = 0;
            int countAllBuyers = 0;
            Queue<int> buyers = CreatingQueue();         
            ServeAllQueue(buyers, ref countAllBuyers, ref countAllPurchase);
        }

        static int GetQueuePeopleNumber()
        {
            bool isWork = true;
            int resault = 0;

            while (isWork)
            {
                Console.WriteLine("How much people in queue you see?");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int resaultParse);

                if (resaultParse >= 0)
                {
                    resault = resaultParse;
                    isWork = false;
                }

                else
                {
                    Console.WriteLine("Input error. Please, input any number:");
                }
            }

            return resault;
        }

        static Queue<int> CreatingQueue()
        {
            Random purchaseCost = new Random();
            int lowerRandomNumber = 50;
            int upperRandomNumber = 1000;

            Queue<int> buyers = new Queue<int>();
            int amountBuyers = GetQueuePeopleNumber();

            for (int i = 0; i < amountBuyers; i++)
            {
                buyers.Enqueue(purchaseCost.Next(lowerRandomNumber, upperRandomNumber));
            }

            return buyers;
        }

        static void ServeAllQueue(Queue<int> buyers, ref int countBuyers, ref int countPurchase)
        {
            Console.WriteLine("Для обслуживания следующего клиента нажмите любую клавишу");

            while (buyers.Count>0)
            {
                Console.Clear();
                countBuyers = buyers.Count;                               
                Console.SetCursorPosition(0, 20);                
                Console.WriteLine("Amount people in the Queue - " + countBuyers);
                Console.WriteLine("Revenue for today - " + countPurchase);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Для обслуживания следующего клиента нажмите любую клавишу");
                Console.ReadKey();                
                countPurchase += buyers.Peek();
                buyers.Dequeue();                
            }

            countBuyers = buyers.Count;
            Console.Clear();
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Amount people in the Queue - " + countBuyers);
            Console.WriteLine("Revenue for today - " + countPurchase);
        }
    }
}
