using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class ProductionWorker : Employee
    {
        
        private int _shiftNumber;
        private decimal _payRate;


        public ProductionWorker(string Name, int Number, int ShiftNumber, decimal PayRate) : base(Name, Number)
        {
          
            _shiftNumber = ShiftNumber;
            _payRate = PayRate;
        }



        public int ShiftNumber { get => _shiftNumber; set => _shiftNumber = value; }

        public decimal PayRate { get => _payRate; set => _payRate = value; }
    }
}
