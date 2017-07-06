using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {

        //    string[] weekDays = new string[7];

        //    for (int i = 0; i < weekDays.Length; i++)
        //    {

        //        Console.Write("Please enter a day of the week: ");
        //        weekDays[i] = Console.ReadLine();

        //    }

        //    Array.Reverse(weekDays);

        //    for (int i = 0; i < weekDays.Length; i++)
        //    {
        //        Console.Write(weekDays[i]);
        //    }


            int min = 1;
            int max = 50;
            bool exitBool = false;
            string exitStr;
            int[] luckyNum = new int[50];
            Random randNum = new Random();

            while (exitBool == false)
            {

                for (int i = 0; i < luckyNum.Length; i++)
                {
                luckyNum[i] = randNum.Next(min, max);
                }

                for (int i = 0; i < luckyNum.Length; i++)
                {
                    if (luckyNum[i] == 3 || luckyNum[i] == 5 || luckyNum[i] == 7 || luckyNum[i] == 11 || luckyNum[i] == 15)
                    {
                        Console.WriteLine(luckyNum[i]);
                    }
                }

                Console.Write("Would you like to try again? If yes press enter and if not enter \"quit\": ");
                exitStr = Console.ReadLine();

                if (exitStr == "quit")
                {
                    exitBool = true;
                }
                else
                {
                    exitBool = false;
                }
                
            }

        }
    }
}
