using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Program
    {
        public static void Main()
        {
            Log log = new SignUpLog();
            Decorator before = new BeforeLog();
            Decorator after = new AfterLog();
            before.Log = log;
            after.Log = log;
            log.WriteLog("Hello!");
        }
    }
}
