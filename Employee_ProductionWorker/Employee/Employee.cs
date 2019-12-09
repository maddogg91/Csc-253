using System;

namespace EmployeeLibrary
{
    public abstract class Employee
    {
        private string _name;
        private int _number;

        public Employee(string Name, int Number)
        {
            _name = Name;
            _number = Number;
        }

       
        //Create Getters and setters for Name and number

        public string Name { get => _name; set => _name = value; }

        public int Number { get => _number; set => _number = value; }
    }
}
