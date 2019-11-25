using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Foreman
    {
        Builder builder;

        public Foreman(Builder builder)
        {
            this.builder = builder;
        }

        public void GiveCommand()
        {
            builder.SetColor();
            builder.SetBase();
            builder.SetTop();
        }
    }
}
