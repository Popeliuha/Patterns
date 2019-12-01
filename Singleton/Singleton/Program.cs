using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ManicureRules inst1 = ManicureRules.Instance();
            ManicureRules inst2 = ManicureRules.Instance();
            Console.WriteLine(ReferenceEquals(inst1, inst2));
            inst1.SetManicureName("asdf");
            Console.WriteLine(inst1.GetManicureName());
        }
    }
}
