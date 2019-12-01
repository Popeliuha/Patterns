using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Hair
    {
        public State State { get; set; }

        public Hair(State state)
        {
            State = state;
        }

        public void ChangeState()
        {
            this.State.Handle(this);
            Console.WriteLine(State);
        }
    }
}
