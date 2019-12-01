using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    class TransactionIterator : ITransactionIterator
    {
        private TransactionCollection transactions;
        private int _current = 0;
        private int _step = 1;
        
        public TransactionIterator(TransactionCollection transactions)
        {
            this.transactions = transactions;
        }

        public Transaction First()
        {
            _current = 0;
            return transactions[_current] as Transaction;
        }

        public Transaction Next()
        {
            _current += _step;
            if (!IsDone)
                return transactions[_current] as Transaction;
            else
                return null;
        }

        public Transaction CurrentTransaction
        {
            get { return transactions[_current] as Transaction; }
        }

        public bool IsDone
        {
            get { return _current >= transactions.Count; }
        }
    }
}
