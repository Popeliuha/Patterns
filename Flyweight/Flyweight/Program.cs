using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        public static void addCarToPoliceDatabase(FlyweightFactory factory, Ticket ticket)
        {
            Console.WriteLine("\nClient: Adding a ticket to database.");

            var flyweight = factory.GetFlyweight(new Ticket
            {
                Train = ticket.Train,
                Price = ticket.Price,
                Route = ticket.Route
            });

            flyweight.Operation(ticket);
        }

        static void Main(string[] args)
        {
            var factory = new FlyweightFactory(
               new Ticket { Route = "Kyiv Lviv", Price = "2000", Train = "pink" },
               new Ticket { Route = "Che Kharkiv", Price = "300", Train = "black" },
               new Ticket { Route = "Moscow Wroclaw", Price = "500", Train = "red" },
               new Ticket { Route = "Che Khotyn", Price = "5", Train = "red" },
               new Ticket { Route = "Lviv Rivne", Price = "6", Train = "white" }
           );
            factory.listFlyweights();

            addCarToPoliceDatabase(factory, new Ticket
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Route = "Che Khotyn",
                Price = "5",
                Train = "red"
            });

            addCarToPoliceDatabase(factory, new Ticket
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Route = "Che Khotyn",
                Price = "1",
                Train = "red"
            });

            factory.listFlyweights();
        }
       
    }
}
