using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ManicureRules
    {
        static ManicureRules uniqueManicureRules;
        string managerData = string.Empty;

        protected ManicureRules() { }

        public static ManicureRules Instance()
        {
            if (uniqueManicureRules == null)
                uniqueManicureRules = new ManicureRules();

            return uniqueManicureRules;
        }

        public void SetManicureName(string id)
        {
            managerData = $"Manicure {id}";
        }

        public string GetManicureName()
        {
            return managerData;
        }
    }
}
