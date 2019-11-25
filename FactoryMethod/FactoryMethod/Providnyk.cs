using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Providnyk : TicketCreator
    {
        public override Ticket FactoryMethod(string name)
        {
            return new TrainTicket(name);
        }
    }
}
