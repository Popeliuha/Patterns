using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Ticket : ITicket
    {
        private string _name;
        private Subscriber client;
        private double cost;

        public Ticket(string name, double cost)
        {
            _name = name;
            this.cost = cost;
        }

        public void Update(Subscriber subscriber)
        {
            Console.WriteLine("Notified: {0}, that" + " coefficient change to {1}.", _name, subscriber.Cost);
            if (subscriber.Cost < cost)
            {
                Console.WriteLine(_name + " wants to buy " + subscriber.GetType().Name + "!");
            }
        }
    }
}
