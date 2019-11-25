using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Hair
    {
        public Hair Hair { protected get; set; }

        public override void CreateHaircut()
        {
            if (Hair != null)
            {
                Hair.CreateHaircut();
            }
        }
    }
}
