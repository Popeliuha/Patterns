using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Ticket : ITicket
    {
        public void Request()
        {
            Console.WriteLine("Ticket: Handling Request.");
        }
    }
}
