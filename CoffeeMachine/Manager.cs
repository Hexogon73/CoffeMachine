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

        public void PrepareOrder(string name_recipe, DictionaryRecipe dr, PaymentSystem ps, MoneyReceiver mr, ResourceBase rb)
        {
            KeyValuePair<string, Dictionary<string, int>> order = new KeyValuePair<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
           if (dr.ShowRecipe(name_recipe) == true) {
               int order_cost = dr.GetPrice(name_recipe);
               ps.PayOrder(order_cost, mr);
               order = dr.GetRecipe(name_recipe);
               dict.Add(order.Key, order.Value);
               foreach (var v in dict[name_recipe])
               {
                   rb.GetPortion(v.Key, v.Value);
               }
           }
        }
    }
}
