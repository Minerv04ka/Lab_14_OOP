using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    public class City

    {
        public string Name; 
        public string Country; 
        public string Region; 
        public int Population; 
        public double YearIncome; 
        public double Area; 
        public bool HasPort; 
        public bool HasAirport;
        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }
}
