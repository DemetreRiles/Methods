/*
Author: Demetre Riles
Date: 1/31/2019
Comments: This is a C# console application that askes for user input, and then calls a method to 
    preform actions to the input.
*/
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // Asks for user input
            Console.WriteLine("Please enter your name...");

            // Try an catch block to handle any exceptions
            try 
            {
                
                // Keeps user input into a varible
                string input = Console.ReadLine();
                
                //Calls Method and is given the users input for evaluation
                Console_Name(input);
            }
            catch 
            {
                // Handles any exception and ask for user to exit program
                Console.WriteLine("Error, please press any key to exit the program...");
                Console.ReadKey(true);
            }
        }

        private static void Console_Name(string name)
        {
            // Try an catch block to handle any exceptions
            try
            {
                // Writes user name to console
                Console.WriteLine("Your name is " + name);

                // Ask for user input to exit program
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true); 
            }
            catch 
            {
                // Handles any exception and ask for user to exit program
                Console.WriteLine("Error, please press any key to exit the program...");
                Console.ReadKey(true); 
            }
        }
    }
}
