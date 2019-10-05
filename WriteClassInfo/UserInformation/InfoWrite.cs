using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UserInformation
{
    
    public class InfoWrite
    {
        StreamWriter outputFile;
        UserInformation.StandardMessages myMessages = new UserInformation.StandardMessages();
       
        //Gets First Name from User
        public string GetFname()
        {
            Console.Write(myMessages.PromptFirstName);
            string fname = Console.ReadLine();
            return fname;
        }

        //Gets Last name from user
        public string GetLname()
        {
            Console.Write(myMessages.PromptLastName);
            string lname = Console.ReadLine();
            return lname;
        }

        //Gets and parses age from user
        public int GetAge()
        {
            Console.Write(myMessages.PromptAge);
            int age = 0;
            string input = Console.ReadLine();
            try
            {
                age= int.Parse(input); 
                
            }

            catch(FormatException)
            {
                Console.WriteLine(myMessages.ErrorMessage);
                Console.ReadLine();
            }
            return age;
        }

        //Gets horoscope from user
        public string GetHoroscope()
        {
            Console.Write(myMessages.PromptHoroscope);
            string horoscope = Console.ReadLine();
            return horoscope;
        }

        //Creates the person class and returns it for the save file

        public Person GetPerson()
        {
            Person person = new Person(GetFname(), GetLname(), GetAge(), GetHoroscope());
            return person;
        }

        //Invokes standard messages for the Menu prompt
        public void DisplayMainMenu()
        {
            bool run = true;
            do
            {
                Console.Write(myMessages.PromptInfo);
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "yes":
                        SaveFile();
                        break;

                    case "no":
                        run = false;
                        break;

                    default:
                        Console.WriteLine(myMessages.ErrorMessage);
                        Console.ReadLine();
                        break;

                }
            }
            while (run == true);
           
        }

        //Saves the gathered information into a text file
        public void SaveFile()
        {
            Person person = GetPerson();
            outputFile = File.CreateText("UserInformation.txt");
            outputFile.WriteLine(person.Fname);
            outputFile.WriteLine(person.Lname);
            outputFile.WriteLine(person.Age);
            outputFile.WriteLine(person.Horoscope);
            outputFile.Close();
            Console.WriteLine(myMessages.PromptFileComplete);
            Console.WriteLine(myMessages.EndSpace);
            
           
        }
    }

    
      
}
