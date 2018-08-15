using Patterns.Builder.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class XMLConverter : Converter
    {
        ResultFile result = new ResultFile();

        public override void ToTxt()
        {
            result.Add(new DeserializeToTxt());
        }

        public override void FromTxt()
        {
            result.Add(new SerializeFromTxt("xml"));
        }

        public override ResultFile GetResult()
        {
            return result;
        }
    }
}
