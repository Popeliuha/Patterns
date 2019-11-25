using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketCreator creator = new Casheer();
            Console.WriteLine("Enter ticket name:");
            string name = Console.ReadLine();
            if (name.Contains("ticket"))
            {
                Ticket ticket = creator.FactoryMethod(name);
                creator.ShowInfo();
            }
            
        }
    }
}
