using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Result
{
    public class ResultFile
    {
        ArrayList parts = new ArrayList();

        public void Add (object part)
        {
            parts.Add(part);
        }
    }
}
