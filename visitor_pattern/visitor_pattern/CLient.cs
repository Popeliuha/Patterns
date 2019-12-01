using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    class CLient : Element
    {
        public string Name { get; set; }
        public double TotalCash { get; set; }
        public int TotalBoughtTickets { get; set; }

        public CLient(string name, double totalCash, int totalBoughtTickets)
        {
            Name = name;
            TotalCash = totalCash;
            TotalBoughtTickets = totalBoughtTickets;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
