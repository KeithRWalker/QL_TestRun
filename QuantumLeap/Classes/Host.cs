using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumLeap.Classes
{
    class Host
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Leaper LeaperHosted { get; set; }
        public Event EventHosted { get; set; }

        public Host(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}


/*3 <-- Most Recent Leap
Location: Memphis, TN
Date:     July 3, 1954
Leaper:   Sam Beckett
Host:     Elvis Presley

2
Location:	Homestead, FL
Date:	    October 26, 1962
Leaper:   Sam Beckett
Host:	    Eddie Elroy

1 <-- First Leap
Location:	St.Louis, Missouri
Date:   	October 6, 1957
Leaper:   Sam Beckett
Host:   	Kenny Sharp*/
