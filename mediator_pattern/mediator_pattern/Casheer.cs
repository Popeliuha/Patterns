using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_pattern
{
    public class Casheer
    {
        public static void SellTicket(User user, string tiket)
        {
            Console.WriteLine(DateTime.Now + " [" + user.Name + "] : " + tiket);
        }
    }
}
