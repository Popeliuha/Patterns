using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    abstract class Decorator : Log
    {
        public Log Log { protected get; set; }
        public override void WriteLog(string message)
        {
            if (Log != null)
            {
                Log.WriteLog(message);
            }
        }
    }
}
