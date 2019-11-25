using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Hair hair = new ThinHair();
            Decorator dirty = new DirtyHair();
            Decorator wash = new WashHair();
            dirty.Hair = hair;
            wash.Hair = dirty;
            wash.CreateHaircut();
        }
    }
}
