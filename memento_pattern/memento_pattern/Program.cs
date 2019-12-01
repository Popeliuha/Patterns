using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Buy buy = new Buy();
            buy.BeginBuy();

            BuyHistory betHistory = new BuyHistory();

            betHistory.History.Push(buy.SaveState());
            buy.BeginBuy();
            buy.BeginBuy();
            buy.BeginBuy();
            buy.RestoreState(betHistory.History.Pop());

            buy.BeginBuy();

            Console.Read();
        }
    }
}
