//Name: Spencer Karpati
//Instructor: Dr. Kathleen Ericson
//Class: CSCI 352
//Description: This program creates a random number guessing game.

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
            Console.WriteLine("Please enter the lower bound"); //Initialize lower bound
            String min = Console.ReadLine();
            Console.WriteLine("Please enter the upper bound"); //Initialize upper bound
            String max = Console.ReadLine();

            Random randNum = new Random(); //Random number object is created.
            int num = randNum.Next(Int32.Parse(min), Int32.Parse(max)); //Integer variable num is set to Random object

            Console.Write("I'm thinking of a number between " + min);
            Console.Write(" and ");
            Console.Write(max);
            Console.Write(" ...which number am I thinking of?");
            Console.WriteLine();

            int userTries = 0; //Counter for the number of attempts made to guess the number.
            bool correct = false; //To check if the user is correct. This will help with looping.

            while (!correct) //While loop to grab constant user input as long as the user isn't correct.
            {
                String userNum = Console.ReadLine(); //Grab user input

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

                else if (Int32.Parse(userNum) == num)
                {
                    Console.WriteLine("You've guessed correctly. Well done.");
                    Console.WriteLine("Attempts: " + userTries);
                }
            }
        }
    }
}
