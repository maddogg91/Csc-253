using System;
using System.IO;

namespace ReadFile
{
    public class FileReader
    {
        //Displays Main menu when called
        public void DisplayMainMenu()
        {
            bool run = true;
            do
            {
                Console.Write("This program displays the information in the file UserInformation\nWould you like to run the program?\n>");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "yes":
                        Console.WriteLine("Loading File...\n");
                        LoadFile();
                        break;

                    case "no":
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadLine();
                        break;

                }
            }

            while (run == true);

        }

        //Reads Userinformation file
            public void LoadFile()
            {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("UserInformation.txt");
                LoadPerson(inputFile);

            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("This file does not exist");
                Console.ReadLine();
            }
        }

        //Creates text for output
        public void LoadPerson(StreamReader inputFile)
        {
            Person person = new Person(" ", " ", 0, " ");
            while(!inputFile.EndOfStream)
            {
                person= GetPerson(inputFile);
            }
            Console.WriteLine("First Name: "+ person.Fname +"\nLast Name: "+ person.Lname + "\nAge: " + person.Age.ToString() + "\nHoroscope: " + person.Horoscope);
            Console.ReadLine();
        }

        //Creates person class
        public  Person GetPerson(StreamReader inputFile)
        {
            Person person = new Person(GetFname(inputFile), GetLname(inputFile), GetAge(inputFile), GetHoroscope(inputFile));
            return person;
        }

        private string GetHoroscope(StreamReader inputFile)
        {
            string input = inputFile.ReadLine();
            return input;
        }

        private int GetAge(StreamReader inputFile)
        {
            int age = 0;
            string input = inputFile.ReadLine();
            try
            {
                age = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Age inputted is invalid, the program will assume the age is 0 until changed");
                Console.ReadLine();
            }
            return age;
        }

        private string GetLname(StreamReader inputFile)
        {
            string input = inputFile.ReadLine();
            return input;
        }

        private string GetFname(StreamReader inputFile)
        {
            string input = inputFile.ReadLine();
            return input;
        }
    }
}
