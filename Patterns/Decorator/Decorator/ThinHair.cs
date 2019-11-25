using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ThinHair : Hair
    {
        public override void CreateHaircut()
        {
            Console.WriteLine("Haircut for thin hair");
        }
    }
}
