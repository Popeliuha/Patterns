using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class AfterLog:Decorator
    {
        public void EndLog()
        {
            Console.WriteLine("Action finished.");
        }

        public override void WriteLog(string message)
        {
            base.WriteLog(message);
            EndLog();
        }
    }
}
