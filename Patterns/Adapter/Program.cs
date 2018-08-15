using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class Program
    {
        public static void Main()
        {
            Driver driver = new Adapter();
            driver.GoToUrl("google.com");
        }
    }
}
