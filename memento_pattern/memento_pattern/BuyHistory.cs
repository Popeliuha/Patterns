using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class BuyHistory
    {
        public Stack<BuyMemento> History { get; private set; }
        public BuyHistory()
        {
            History = new Stack<BuyMemento>();
        }
    }
}
