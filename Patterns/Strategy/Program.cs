using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Program
    {
        public static void Main()
        {
            var add = new PlusStrategy();
            var context = new Context(add);
            context.Add();
            context.OutputResult();
            Console.ReadLine();
        }
    }
}
