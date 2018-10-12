using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Table of Powers!!");

            string Continue;

            do {

                //User is prompted to enter a number

            Console.WriteLine("Please enter a number");

                string userInput = Console.ReadLine();
                int userNum = int.Parse(userInput);

                Console.WriteLine("\n");

                Console.WriteLine("Number    Square     Cube");

                Console.WriteLine("==========================");

                //execution of for loop to determine the numbers being used

                for (int i = 1; i <= userNum; i++)
                {
                    /*Using place holders to determine location of where the numbers will display
                     * Using Math.pow to bring number to power of for squared and cubed*/ 
                    
                    Console.WriteLine("{0}          {1}          {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
                }
                Console.ReadKey();

                // User is prompted if they would like to continue.

                Console.WriteLine("Continue? (Y/N):");
                Continue = Console.ReadLine().ToLower();
            } while (Continue == "y" || Continue == "yes");
        }
    }
}