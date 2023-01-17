using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_Getting_Into_Git
{
    class Program
    {
        static void Main(string[] args)
        {
                Random randNum = new Random();
                Console.WriteLine("I'm thinking of a number between 0 and 100...which number am I thinking of?");

                int max = 100;
                int min = 0;
                int num = randNum.Next(min, max);
                int userTries = 0;
                bool correct = false;

                while (!correct)
                {
                String userNum = Console.ReadLine();

                if (Int32.Parse(userNum) > num)
                    {
                        Console.WriteLine("Number is higher than answer. Try again");
                        userTries++;
                    }

                    else if (Int32.Parse(userNum) < num)
                    {
                        Console.WriteLine("Number is lower than answer. Try again");
                        userTries++;
                    }

                    else if(Int32.Parse(userNum) == num)
                    {
                        Console.WriteLine("You've guessed correctly. Well done.");
                        Console.WriteLine("Attempts: " + userTries);
                    }
                }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            }
        }
    }
