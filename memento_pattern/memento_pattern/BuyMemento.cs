using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class BuyMemento
    {
        public TimeSpan Time { get; private set; }

        public BuyMemento(TimeSpan time)
        {
            this.Time = time;
        }
    }
}
