using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class PdfReader
    {
        Converter converter;

        public PdfReader(Converter converter)
        {
            this.converter = converter;
        }
        
        public void Construct()
        {
            converter.ToTxt();
            converter.FromTxt();
        }
    }
}
