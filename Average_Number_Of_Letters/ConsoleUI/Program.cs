using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /**
* September 15, 2019
* CSC 253
* Robert Charity
* Average Number of Letters
* This program counts the amount of words entered by the User and gives an average number of letters.
*/
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {


            bool run = true;

            while (run == true)
            {
                Console.Write("Welcome to the word counter program\n\n\n\n\n\n\nEnter Run to run the Program\nEnter Exit to exit the program\n>");
                string input = Console.ReadLine();
                input = input.ToLower();
                switch (input)
                {
                    case "run":
                        GetInput();
                        Console.ReadLine();

                        break;

                    case "exit":
                        run = false;
                        break;

                    default:
                        Console.WriteLine("\nError: Invalid entry\n");
                        Console.ReadLine();
                        break;
                }
            }

        }

        static void GetInput()
        {
            Console.Write("\nEnter your sentence below.\n>");
            WordCount(Console.ReadLine());
        }

        static void WordCount(string input)
        {
            if (input == "")
            {
                Console.WriteLine("\n\n\n\nYou didn't enter anything...\n");
            }
            else
            {
                
                string[] wordCount = input.Split();
                if (wordCount.Length <= 1)
                {
                    Console.WriteLine("\n\n\n\nYou have entered " + wordCount.Length.ToString() + " word\n" +
                    "");
                }
                else
                {
                    Console.WriteLine("\n\n\n\nYou have entered " + wordCount.Length.ToString() + " words\n" +
                    "");
                }

                WordAverage(wordCount);
            }

        
        }

        static void WordAverage(string[] words)
        {
            int count = 0;
            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    count++;
                }
            }
            Console.WriteLine("\nYour average number of letters in each word is: " + count / words.Count() + "\n");
        }
    }
}
