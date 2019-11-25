using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        Hair hair = new Hair();
        Nails nails = new Nails();
        Cosmetologyst cosmetologyst = new Cosmetologyst();

        public void HairAndNails()
        {
            hair.MakeHaircut();
            nails.MakeManicure();
        }

        public void CosmetologystAndNails()
        {
            cosmetologyst.VisitCosmetologyst();
            nails.MakeManicure();
        }
    }
}
