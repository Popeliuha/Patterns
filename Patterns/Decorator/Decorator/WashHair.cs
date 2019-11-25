using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WashHair : Decorator
    {
        void WashHead()
        {
            Console.WriteLine("Washing");
        }
        public override void CreateHaircut()
        {
            base.CreateHaircut();
            WashHead();
        }
    }
}
