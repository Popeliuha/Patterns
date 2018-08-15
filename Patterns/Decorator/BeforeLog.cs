using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class BeforeLog:Decorator
    {
        string addedState = "Action started. </br>";
        public override void WriteLog(string message)
        {
            Console.WriteLine(addedState);
            base.WriteLog(message);
        }
    }
}
