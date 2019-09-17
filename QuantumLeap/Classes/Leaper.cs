using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumLeap.Classes
{
    class Leaper
    {
        public string Name { get; set; }
        public Event CurrentEvent { get; set; }
        public int LeaperCash { get; set; }
        public Budget LeaperBudget { get; set; }

        public List<Event> PastEvents { get; set; }

        public Leaper(string name)
        {
            Name = name;
            LeaperCash = 1000;
        }

        public void Jump(Host whatHost, Event whatEvent)
        {
            if (whatHost.Year == whatEvent.Year)
            {
                Console.WriteLine($"{Name} You are Jumping into {whatHost.Name}, The year is {whatEvent.Year}");
                var budgetCheck = new Budget(this, whatEvent.Year).CheckMoneyToJump(5);

            }
        }
    }
}
