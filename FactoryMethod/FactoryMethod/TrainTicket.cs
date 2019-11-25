using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TrainTicket : Ticket
    {

        public TrainTicket(string name)
        {
            Console.WriteLine(name);
        }
    }
}
