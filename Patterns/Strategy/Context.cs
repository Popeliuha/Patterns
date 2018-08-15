using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Context
    {
        Strategy strategy;
        public string a = "a";
        public string b = "b";

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public string Add()
        {
            return strategy.AddStrings(a, b);
        }

        public void OutputResult()
        {
            Console.WriteLine(Add());
        }
    }
}
