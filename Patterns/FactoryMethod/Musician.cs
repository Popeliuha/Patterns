using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    abstract class Musician
    {
        public string Name { get; set; }

        public Musician(string n)
        {
            Name = n;
        }
        abstract public Music Create();
    }
}
