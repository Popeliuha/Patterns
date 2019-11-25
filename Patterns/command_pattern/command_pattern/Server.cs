using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    public class Server
    {
        public Server()
        {
        }
        public void Invoke(Ticket ticket)
        {
            Console.WriteLine("Processing..");
            ticket.Execute();
        }
    }
}
