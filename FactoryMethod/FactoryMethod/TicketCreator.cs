using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class TicketCreator
    {
        Ticket ticket;

        public abstract Ticket FactoryMethod(string name);

        public void ShowInfo()
        {
            Console.WriteLine(ticket.Name.ToString());
        }
    }
}
