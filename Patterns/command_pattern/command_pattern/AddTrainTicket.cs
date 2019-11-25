using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{

    public class AddTrainTicket : Ticket
    {
        public AddTrainTicket()
        {
        }
        public void Execute()
        {
            Console.WriteLine("Add train ticket");
        }
    }
}
