using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    abstract class Subscriber
    {
        private double cost;
        private List<ITicket> ticket = new List<ITicket>();

        public Subscriber(double coefficient)
        {
            cost = coefficient;
        }

        public void Attach(ITicket ticket)
        {
            this.ticket.Add(ticket);
        }

        public void Detach(ITicket ticket)
        {
            this.ticket.Remove(ticket);
        }

        public void Notify()
        {
            foreach (ITicket server in ticket)
            {
                server.Update(this);
            }

            Console.WriteLine("");
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                if (cost != value)
                {
                    cost = value;
                    Notify();
                }
            }
        }
    }
}
