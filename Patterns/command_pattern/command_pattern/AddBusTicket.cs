using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    public class AddBusTicket : Ticket
    {
        public AddBusTicket()
        {
        }
        public void Execute()
        {
            Console.WriteLine("Add Bus ticket.");
        }
    }
}
