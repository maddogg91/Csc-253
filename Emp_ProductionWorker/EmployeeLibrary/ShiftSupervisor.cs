using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class ShiftSupervisor : Employee
    {
        private decimal _salary;
        private decimal _bonus;

        public ShiftSupervisor(string Name, int Number, decimal Salary) : base(Name, Number)
        {
            _salary = Salary;
            _bonus = 5000m;
        }

        public decimal Salary { get => _salary; set => _salary = value; }

        public decimal Bonus { get => _bonus; set => _bonus = value; }
    }
}
