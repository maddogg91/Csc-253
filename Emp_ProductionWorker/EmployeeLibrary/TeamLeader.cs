using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    //Team leader uses Production Worker class
    public class TeamLeader : ProductionWorker
    {
        private decimal _monthlyBonus;
        private double _requiredTrainingHours;

        private double _attendedHours;

        public TeamLeader(string Name, int Number, int ShiftNumber, decimal PayRate, double Hours) : base(Name, Number, ShiftNumber, PayRate)
        {
           
            _attendedHours = Hours;
            _monthlyBonus = 1000m;
            _requiredTrainingHours = 40;

        }

        public double AttendedHours { get => _attendedHours; set => _attendedHours = value; }
        public double RequiredTrainingHours { get => _requiredTrainingHours;  }
        public decimal MonthlyBonus { get => _monthlyBonus;  }
    }
}
