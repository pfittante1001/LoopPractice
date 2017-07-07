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


            //int min = 1;
            //int max = 50;
            //bool exitBool = false;
            //string exitStr;
            //int[] luckyNum = new int[50];
            //Random randNum = new Random();

            //while (exitBool == false)
            //{

            //    for (int i = 0; i < luckyNum.Length; i++)
            //    {
            //    luckyNum[i] = randNum.Next(min, max);
            //    }

            //    for (int i = 0; i < luckyNum.Length; i++)
            //    {
            //        if (luckyNum[i] == 3 || luckyNum[i] == 5 || luckyNum[i] == 7 || luckyNum[i] == 11 || luckyNum[i] == 15)
            //        {
            //            Console.WriteLine(luckyNum[i]);
            //        }
            //    }

            //    Console.Write("Would you like to try again? If yes press enter and if not enter \"quit\": ");
            //    exitStr = Console.ReadLine();

            //    if (exitStr == "quit")
            //    {
            //        exitBool = true;
            //    }
            //    else
            //    {
            //        exitBool = false;
            //    }

            //}

            //string exitUpper = "no";
            //char[] custId = new char[6];

            //while (exitUpper != "QUIT")
            //{
            //    Console.Write("Would you like to check in for you appointment: ");
            //    string exit = Console.ReadLine();
            //    exitUpper = exit.ToUpper();

            //    if (exitUpper != "QUIT")
            //    {
            //        Console.Write("Patient Check-in System \n");
            //        Console.Write("Please enter your first name \n");
            //        string fullName = Console.ReadLine();
            //        Console.Write("Please enter your six digit patient ID name \n");
            //        for (int i = 0; i < custId.Length; i++)
            //        {
            //            string charStr = Console.ReadLine();
            //            custId[i] = char.Parse(charStr);
            //        }

            //        Console.Write("What if the patients check-in time: \n");
            //        string apptTime = Console.ReadLine();
            //    }


            //}


            //string contPro = "yes";
            //bool exit = false;

            //do
            //{
            //    int numGrades = 0;
            //    decimal totalGrade = 0.0m;



            //    Console.Write("Would you like me to calculate you GPA? Type Yes to continue or no to exit: ");
            //    contPro = Console.ReadLine();

            //    if (contPro != "no")
            //    {
            //        exit = true;

            //        Console.WriteLine("How many grades would you like to enter: ");
            //        string numGradesStr = Console.ReadLine();
            //        numGrades = int.Parse(numGradesStr);

            //        char[] stuGrades = new char[numGrades];

            //        for (int i = 0; i < numGrades; i++)
            //        {
            //            Console.Write("Please enter grade # {0}: ", i + 1);
            //            string letterGrade = Console.ReadLine();
            //            stuGrades[i] = char.Parse(letterGrade);

            //            decimal gradeConv = 0.0m;
            //            switch (stuGrades[i])
            //            {
            //                case ('a'):
            //                    gradeConv = 4.0m;
            //                    break;
            //                case ('b'):
            //                    gradeConv = 3.0m;
            //                    break;
            //                case ('c'):
            //                    gradeConv = 2.0m;
            //                    break;
            //                case ('d'):
            //                    gradeConv = 1.0m;
            //                    break;
            //                case ('f'):
            //                    gradeConv = 0.0m;
            //                    break;
            //            }


            //            totalGrade = totalGrade + gradeConv;

            //        }

            //        Console.WriteLine(" Your GPA is {0} ", totalGrade / numGrades);
            //    }else
            //    {
            //        exit = false;
            //    }
            //} while (exit == true);

            for (int k = 0; k < 1; k++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(+i);

                    for (int j = 2; j <= 5; j++)
                    {
                        Console.Write("\t" + j * i);
                    }
                    Console.WriteLine();
                }
            }

                //for (int i = 0; i <= 10; i++) //rows
                //{
                //    Console.Write(i);

                //    for (int j = 1; j < i ; j++) //columns
                //    {
                //        Console.Write(j);
                //    }
                //    Console.WriteLine(); //creates new line after colums print 

                //}

                //bool exit = false;
                //int ctr = 0;
                //while (exit == false)
                //{

                //    string[] favMovies = new string[10];
                //    Console.Write("Please enter up to ten of your favorite movies. \n");

                //    for (int i = 0; i < favMovies.Length; i++)
                //    { 
                //        Console.Write("Enter movie number " + (i + 1 )+ " ? or quit to exit: ");
                //        string namesMovies = Console.ReadLine();

                //        if(namesMovies == "quit")
                //        {
                //            exit = true;
                //            break;
                //        }else
                //        {
                //            favMovies[i] = namesMovies;
                //            ctr++;
                //        }

                //        Console.WriteLine(ctr);

                //    }

                //    for (int i = 0; i <= ctr; i++)
                //    {
                //        if (favMovies[i] == (null))
                //        {
                //            break;
                //        }
                //        if (favMovies[i].StartsWith("e"))
                //        {
                //            Console.Write("{0} ", favMovies[i]);
                //        }
                //        else if (favMovies[i].StartsWith("i"))
                //        {
                //            Console.Write("{0} ", favMovies[i]);
                //        }
                //        else if (favMovies[i].StartsWith("o"))
                //        {
                //            Console.Write("{0} ", favMovies[i]);
                //        }
                //        else if (favMovies[i].StartsWith("u"))
                //        {
                //            Console.Write("{0} ", favMovies[i]);
                //        }
                //        else if (favMovies[i].StartsWith("a"))
                //        {
                //            Console.Write("{0} ", favMovies[i]);
                //        }                
                //     }
                //}


                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
    }
}
