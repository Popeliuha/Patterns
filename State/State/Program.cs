using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Hair hair = new Hair(new StraightHair());
            hair.ChangeState();
            hair.ChangeState();
        }
    }
}
