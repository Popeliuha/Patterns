using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    class TransactionCollection
    {
        private ArrayList _items = new ArrayList();

        public TransactionIterator CreateIterator()
        {
            return new TransactionIterator(this);
        }
        
        public int Count
        {
            get { return _items.Count; }
        }
        
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
