using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    class TotalCashVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            CLient user = element as CLient;

            user.TotalCash *= 2;
            Console.WriteLine($"{user.GetType().Name} { user.Name}'s new winnings cash: {user.TotalCash}");
        }
    }
}
