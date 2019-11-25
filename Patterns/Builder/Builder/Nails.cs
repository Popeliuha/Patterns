using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Nails
    {
        ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}
