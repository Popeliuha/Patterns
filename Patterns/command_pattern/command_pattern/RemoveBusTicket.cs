using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    public class RemoveBusTicket : Ticket
    {
        public RemoveBusTicket()
        {
        }
        public void Execute()
        {
            Console.WriteLine("Remove Bus ticket");
        }
    }
}
