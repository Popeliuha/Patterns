using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class SignUpLog : Log
    {
        public override void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
