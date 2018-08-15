using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class JazzMusic : Music
    {
        public JazzMusic()
        {
            Console.WriteLine("Let it snow, let it snow, let it snow...");
        }
    }
}
