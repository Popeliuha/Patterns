using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Builder.Result;

namespace Patterns.Builder
{
    public abstract class Converter
    {
        public abstract void FromTxt();

        public abstract void ToTxt();

        public abstract ResultFile GetResult(); 
    }
}
