using Patterns.Facade.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class Order
    {
        Fish salmon = new Fish();
        Cucumber saltedCucumber = new Cucumber();
        Milk milk = new Milk();
        Wine redWine = new Wine();

        public void EatRestaurantDish()
        {
            salmon.EatFish();
            redWine.DrinkWine();
        }

        public void EatGoodbyeAssDish()
        {
            salmon.EatFish();
            saltedCucumber.EatCucumber();
            milk.DrinkMilk();
        }
        public void DrinkDeathCoctail()
        {
            milk.DrinkMilk();
            redWine.DrinkWine();
        }
    }
}
