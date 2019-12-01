using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User nataliia = new User("Nataliia");
            User valeria = new User("Valeria");

            nataliia.buyTicket("Train ticket");
            valeria.buyTicket("Bus ticket");

            Console.ReadLine();
        }
    }
}
