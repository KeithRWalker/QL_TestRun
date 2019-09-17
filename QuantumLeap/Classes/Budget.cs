using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumLeap.Classes
{
    class Budget
    {
        public Leaper Leaper { get; set; }
        public int Cash { get; set; }
        public int Year { get; set; }
        public Budget(Leaper leaper, int year)
        {
            Leaper = leaper;
            Year = year;
            Cash = leaper.LeaperCash;
        }

        public bool CheckMoneyToJump(int numOfDays)
        {
            if (Cash >= 100*numOfDays)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
