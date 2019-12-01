using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    interface ITransactionIterator
    {
        Transaction First();
        Transaction Next();
        bool IsDone { get; }
        Transaction CurrentTransaction { get; }
    }
}
