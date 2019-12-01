using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    class Transaction
    {
        private string name;

        public Transaction(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
