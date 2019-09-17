using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumLeap.Classes
{
    class Event
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int Year { get; set; }
        public Leaper ELeaper { get; set; }
        public Host EHost { get; set; }
        public int CostPerDay;
        public List<Host> AvalibleHosts { get; set; }

        public Event(string location, int year, Host host, int place)
        {
            Id = place;
            Location = location;
            Year = year;
            EHost = host;
            CostPerDay = 100;
        }

        public void GetMenuInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"EVENT #{Id.ToString()}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"LOCATION: {Location}");
            Console.WriteLine($"DATE: {Year}");
            Console.WriteLine($"HOST: {EHost.Name}");
            Console.WriteLine("-------------------------------");
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
