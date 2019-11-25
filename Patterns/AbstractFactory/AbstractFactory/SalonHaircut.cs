using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SalonHaircut : AbstractHairCut
    {
        public override void Interact(AbstractHairColoring coloring)
        {
            Console.WriteLine($"{this} interacts with {coloring} and creates new hair");
        }
    }
}
