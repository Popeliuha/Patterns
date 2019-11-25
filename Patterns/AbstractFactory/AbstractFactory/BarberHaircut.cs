using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BarberHaircut : AbstractHairCut
    {
        public override void Interact(AbstractHairColoring color)
        {
            Console.WriteLine($"{this} interacts with {color} and creates new hair");
        }
    }
}
