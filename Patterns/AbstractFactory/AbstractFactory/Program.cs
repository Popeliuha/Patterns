using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client;

            client = new Client(new BarberFactory());
            client.Run();

            client = new Client(new SalonFactory());
            client.Run();
        }
    }
}
