using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            
            RemoveBusTicket removeBusTicket = new RemoveBusTicket();
            server.Invoke(removeBusTicket);
            AddBusTicket addBusTicket = new AddBusTicket();
            server.Invoke(addBusTicket);

            RemoveTrainTicket removeTrainTicket = new RemoveTrainTicket();
            server.Invoke(removeTrainTicket);
            AddTrainTicket addTrainTicket = new AddTrainTicket();
            server.Invoke(addTrainTicket);

            Console.ReadLine();
        }
    }
}
