using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Client : Subscriber
    {
        public Client(double cost) : base(cost) { }
    }
}
