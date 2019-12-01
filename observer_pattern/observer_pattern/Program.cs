using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(10000);
            client.Attach(new Ticket("Kyiv", 8000));
            client.Attach(new Ticket("Madrid", 1000));
            client.Attach(new Ticket("Moon", 1000));

            client.Cost = 8000;
            client.Cost = 1000;

            Console.ReadKey();
        }
    }
}
