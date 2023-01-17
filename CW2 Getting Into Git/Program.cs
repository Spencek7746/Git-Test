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
            Random randNum = new Random(); //Random number object is created.
            Console.WriteLine("I'm thinking of a number between 0 and 100...which number am I thinking of?");

            int max = 100;
            int min = 0;
            int num = randNum.Next(min, max); //Integer variable num is set to Random object
            int userTries = 0;
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
