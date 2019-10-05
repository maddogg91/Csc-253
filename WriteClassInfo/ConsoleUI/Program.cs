using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformation;

namespace ConsoleUI
{
    /**
* October 5th, 2019
* CSC 253
* Robert Charity II
* ReadClassInfo
* This program writes user inputted information into a file named UserInformation.
*/
    class Program
    {
        
        static void Main(string[] args)
        {
            //Creates InfoWrite Class to the program to run
            UserInformation.InfoWrite writeClass = new UserInformation.InfoWrite();

            //Invokes Menu method
            writeClass.DisplayMainMenu();
           

        }
    }
}
