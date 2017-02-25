using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class Manager
    {
        public void GetAllRecept(DictionaryRecipe dr)
        {
            dr.ShowAllRecipe();
        }

        public void PrepareOrder(string name_recipe, DictionaryRecipe dr, PaymentSystem ps, MoneyReceiver mr)
        {
           if (dr.ShowRecipe(name_recipe) == true) {
               int order_cost = dr.GetPrice(name_recipe);
               ps.PayOrder(order_cost, mr);
           }
        }
    }
}
