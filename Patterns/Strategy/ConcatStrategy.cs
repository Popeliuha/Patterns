using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class ConcatStrategy : Strategy
    {
        public override string AddStrings(string a, string b)
        {
            return String.Concat(a, b);
        }
    }
}
