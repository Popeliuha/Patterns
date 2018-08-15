using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Musician singer = new JazzMusician("John Bell");
            Music letItSnow = singer.Create();

            singer = new RockMusician("Jonny Cash");
            Music highwayToHell = singer.Create();

            Console.ReadLine();
        }
    }
}
