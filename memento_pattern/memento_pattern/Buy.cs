using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class Buy
    {
        private TimeSpan time = new TimeSpan(10, 30, 0);
        private string name = "Train";
        private int counter = 0;
        public void BeginBuy()
        {
            if (counter == 0)
            {
                counter++;
            } else
            {
                TimeSpan addtime = TimeSpan.FromMinutes(10);
                this.time = time.Add(addtime);
            }
            Console.WriteLine("Ticket: {0} will be at {1} today", name, time);
        }
     
        public BuyMemento SaveState()
        {
            Console.WriteLine("Save: Ticket: {0} will be at {1} today", name, time);
            return new BuyMemento(time);
        }

        public void RestoreState(BuyMemento memento)
        {
            this.time = memento.Time;
            Console.WriteLine("Ticket: {0} will take place in the previous time at {1} today", name, time);
        }
    }
}
