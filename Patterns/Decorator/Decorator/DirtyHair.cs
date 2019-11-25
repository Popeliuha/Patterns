using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DirtyHair : Decorator
    {
        string hairDirty = "Dirty hair";
        public override void CreateHaircut()
        {
            base.CreateHaircut();
            Console.WriteLine(hairDirty);
        }
    }
}
