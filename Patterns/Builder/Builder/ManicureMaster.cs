using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ManicureMaster : Builder
    {
        Nails nails = new Nails();

        public override void SetColor()
        {
            nails.Add(new Color());
        }

        public override void SetBase()
        {
            nails.Add(new Base());
        }

        public override void SetTop()
        {
            nails.Add(new Top());
        }

        public override Nails GetManicure()
        {
            return nails;
        }
    }
}
