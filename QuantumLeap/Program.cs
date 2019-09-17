using System;
using System.Collections.Generic;
using QuantumLeap.Classes;

namespace QuantumLeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventCollection = new List<Event>();
            var hostCollection = new List<Host>();

            var HostA = new Host("Elvis Presley", 1954);
            var EventA = new Event("Memphis, TN", 1954, HostA, 1);
            eventCollection.Add(EventA);
            //hostCollection.Add(HostA);

            var HostB = new Host("Eddie Elroy", 1962);
            var EventB = new Event("Homestead, FL", 1962, HostB, 2);
            eventCollection.Add(EventB);
            //hostCollection.Add(HostB);

            var HostC = new Host("Kenny Sharp", 1957);
            var EventC = new Event("St.Louis, Missouri", 1957, HostC, 3);
            eventCollection.Add(EventC);
            //hostCollection.Add(HostC);

            Console.WriteLine("Hello, Welcome to Quantum Leap!");
            Console.WriteLine("Please Enter your name!");
            var nameResp = Console.ReadLine();
            var userJumper = new Leaper(nameResp);
            var userName = userJumper.Name;
            Console.WriteLine($"Welcome {userName}! You are now a Quantum Leaper");
            Console.WriteLine(" You have been tasked to travel back in Time to correct mistakes that have happened");
            Console.WriteLine("You will shortly see a list of Events that need to be corrected.");
            foreach (var Event in eventCollection)
            {
                Event.GetMenuInfo();
            }
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
