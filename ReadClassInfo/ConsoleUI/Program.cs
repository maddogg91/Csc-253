using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadFile;

namespace ConsoleUI
{
/**
* October 5th, 2019
* CSC 253
* Robert Charity II
* ReadClassInfo
* This program reads information from a file named UserInformation and loads the information into a class named Person.
*/
    class Program
    {
        static void Main(string[] args)
        {
            //Creates Readfile class
            ReadFile.FileReader newFile = new ReadFile.FileReader();

            //Runs Menu
            newFile.DisplayMainMenu();



            
        }
    }
}
