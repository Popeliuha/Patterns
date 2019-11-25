using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ManicureMaster();
            Foreman foreman = new Foreman(builder);
            foreman.GiveCommand();

            Nails nails = builder.GetManicure();
        }
    }
}
