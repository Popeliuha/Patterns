using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Result
{
    public class SerializeFromTxt
    {
        public SerializeFromTxt(string type)
        {
            Console.WriteLine("Serialized to " + type);
        }
    }
}
