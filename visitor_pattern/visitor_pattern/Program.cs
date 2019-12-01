using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientCollection e = new ClientCollection();
            e.Attach(new CLient("Andriy", 1000, 12));
            e.Attach(new CLient("Valeria", 3000, 4));
            e.Attach(new CLient("Nataliia", 5000, 21));

            Console.WriteLine("Our site is giving the bonus to a total amount of cash on the balance...\n");
            e.Accept(new TotalCashVisitor());

            Console.ReadKey();
        }
    }
}
