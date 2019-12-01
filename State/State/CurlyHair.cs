using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CurlyHair : State
    {
        public override void Handle(Hair hair)
        {
            hair.State = new StraightHair();
        }
    }
}
