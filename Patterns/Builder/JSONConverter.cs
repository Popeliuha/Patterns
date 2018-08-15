using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Builder.Result;

namespace Patterns.Builder
{
    public class JSONConverter : Converter
    {
        ResultFile result = new ResultFile();

        public override void ToTxt()
        {
            result.Add(new DeserializeToTxt());
        }

        public override void FromTxt()
        {
            result.Add(new SerializeFromTxt("json"));
        }

        public override ResultFile GetResult()
        {
            return result;
        }
    }
}
