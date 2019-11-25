using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SalonFactory : AbstractFactory
    {
        public override AbstractHairCut DoHaircut()
        {
            return new SalonHaircut();
        }

        public override AbstractHairColoring DyeHair()
        {
            return new SalonHairColoring();
        }
    }
}
