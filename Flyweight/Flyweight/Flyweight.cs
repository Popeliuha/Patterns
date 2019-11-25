using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Flyweight
    {
        private Ticket _sharedState;

        public Flyweight(Ticket ticket)
        {
            this._sharedState = ticket;
        }

        public void Operation(Ticket uniqueState)
        {
            Console.WriteLine($"Flyweight: Displaying shared {_sharedState} and unique {uniqueState} state.");
        }
    }
}
