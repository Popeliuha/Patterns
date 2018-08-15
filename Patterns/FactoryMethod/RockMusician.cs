using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class RockMusician : Musician
    {
        public RockMusician(string n) : base(n)
        { }

        public override Music Create()
        {
            return new RockMusic();
        }
    }
}
