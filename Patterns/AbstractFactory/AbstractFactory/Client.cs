using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private AbstractHairCut haircut;
        private AbstractHairColoring coloring;

        public Client(AbstractFactory factory)
        {
            haircut = factory.DoHaircut();
            coloring = factory.DyeHair();
        }

        public void Run()
        {
            haircut.Interact(coloring);
        }
    }
}
