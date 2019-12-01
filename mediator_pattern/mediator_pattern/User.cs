using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_pattern
{
    public class User
    {

        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void buyTicket(string message)
        {
            Casheer.SellTicket(this, message);
        }
    }
}
