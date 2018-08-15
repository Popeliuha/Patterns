using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class Program
    {
        public static void Main()
        {
            Order order = new Order();
            order.EatRestaurantDish();
            order.EatGoodbyeAssDish();
            order.DrinkDeathCoctail();
        }
    }
}
