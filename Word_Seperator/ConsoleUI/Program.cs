using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /**
    * September 15th, 2019
    * CSC 253
    * Robert Charity
    * Word Seperator
    * This program seperates bunched up words and seperates them into a sentence.
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
                Console.Write("Welcome to the word seperator program\n\n\n\n\n\n\nEnter Run to run the Program\nEnter Exit to exit the program\n>");
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
            bool run = true;
            while (run == true)
            {
                Console.Write("\nEnter your sentence below.\n>");
                string input = Console.ReadLine();
                if (input.Contains(" "))
                {
                    Console.WriteLine("Please enter a sentence that's ran together");
                }

                else
                {
                    WordSeperator(input);
                    run = false;
                }
            }
            
           
        }

        static void WordSeperator(string input)
        {
            int count = 0;
            string sentence = "";
            string s= "";
            foreach(char letter in input)
            {
                if (Char.IsUpper(letter) && count > 0)
                {
                   
                 s = " " + letter.ToString().ToLower();
                    

                   
                    
                    
                    
                   
                }
                else
                {
                    s = letter.ToString();
                    
                    count++;
                }
                sentence = sentence + s;
            }
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
