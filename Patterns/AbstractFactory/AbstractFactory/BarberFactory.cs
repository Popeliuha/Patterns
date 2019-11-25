using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BarberFactory : AbstractFactory
    {
        public override AbstractHairCut DoHaircut()
        {
            return new BarberHaircut();
        }

        public override AbstractHairColoring DyeHair()
        {
            return new BarberHairColoring();
        }
    }
}
