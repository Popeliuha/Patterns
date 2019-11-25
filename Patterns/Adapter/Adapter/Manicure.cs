using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Manicure : ByingGel,  IManicure
    {
        public void DoManicure()
        {
            BuyGel();
            Console.WriteLine("Doing manicure");
        }
    }
}
