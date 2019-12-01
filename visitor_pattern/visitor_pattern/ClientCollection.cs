using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    class ClientCollection
    {
        private List<CLient> clients = new List<CLient>();

        public void Attach(CLient user)
        {
            clients.Add(user);
        }

        public void Detach(CLient user)
        {
            clients.Remove(user);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (CLient e in clients)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }

}
