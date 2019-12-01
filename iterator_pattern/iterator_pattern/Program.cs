using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TransactionCollection collection = new TransactionCollection();
            collection[0] = new Transaction("1");
            collection[1] = new Transaction("2");
            collection[2] = new Transaction("3");
            collection[3] = new Transaction("4");
            collection[4] = new Transaction("5");

            TransactionIterator iterator = collection.CreateIterator();

            Console.WriteLine("Collection of transactions");

            for (Transaction item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
