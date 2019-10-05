using System;

namespace ClassLibrary
{
    public class StandardMessages
    {
        public string PromptInfo
        {
            get
            { return "This program will take user information and write it into a file called userinformation"; }
        }

        //When called prompts First Name from user
        public string PromptFirstName
        {
            get
            {
                return GetInformation("first name");
            }
        }
        //When called prompts Last Name from user
        public string PromptLastName
        {
            get
            {
                return GetInformation("last name");
            }
        }
        //When called prompts Age from user
        public string PromptAge
        {
            get
            {
                return GetInformation("age");
            }
        }
        //When called prompts Sign from user
        public string PromptHoroscope
        {
            get
            {
                return GetInformation("horoscope sign");
            }
        }
        //Formats text to avoid writing the same text over and over above.
        public string GetInformation (string info)
        {
            
           

            return "Please enter your " + info + "\n>"; 
        }

        

        public string ErrorMessage
        {
            get
            {
                return "Invalid entry";
            }
            
        }

      


    }
}
