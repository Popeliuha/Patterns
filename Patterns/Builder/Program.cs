using Patterns.Builder.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class Program
    {
        public static void Main()
        {
            Converter converter = new XMLConverter();
            PdfReader reader = new PdfReader(converter);
            reader.Construct();

            ResultFile result = converter.GetResult();
            Console.ReadKey();
        }
    }
}
