using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    abstract class Driver
    {
        public abstract void GoToUrl(string Url);
    }
}
