using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class JazzMusician : Musician
    {
        public JazzMusician(string n) : base(n)
        { }

        public override Music Create()
        {
            return new JazzMusic();
        }
    }
}
