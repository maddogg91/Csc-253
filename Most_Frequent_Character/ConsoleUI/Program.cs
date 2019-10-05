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
* Frequent Character
* This program displays the most frequent character from a string.
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
                Console.Write("Welcome to the character frequency program\n\n\n\n\n\n\nEnter Run to run the Program\nEnter Exit to exit the program\n>");
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
            WordSplit(Console.ReadLine());
        }

        static void WordSplit(string input)
        {
            if (input == "")
            {
                Console.WriteLine("\n\n\n\nYou didn't enter anything...\n");
            }
            else
            {

                string[] words = input.Split();

                LetterFrequency(words);

            }
        }

         static void LetterFrequency(string[] words)
         {
            int[] charCount = new int[256];
            char letter = ' ';
           
           
                
                foreach (string word in words)
                {
                int length = word.Length;
                for (int i = 0; i < length; i++)
                {
                    charCount[word[i]]++;
                }

                int maxCount = -1;
               
                for (int i= 0; i < length; i++)
                {
                    if (maxCount < charCount [word[i]])
                    {
                        
                        letter = word[i];
                    }
                }
                
            }
            Console.WriteLine("Your most frequent character is: " + letter);
        }
    }
}

