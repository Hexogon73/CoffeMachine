using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class Recipe
    {
        public string name;
        Dictionary<string, int> ingredients = BuildDictionary();

        private static Dictionary<string, int> BuildDictionary()
        {
            return new Dictionary<string, int>
            {
                {"стакан", 1},
                {"кофе", 20},
                {"вода", 100},
                {"сахар", 30},
                {"ложка", 1},
                {"цена", 100}
            };
        }

        public void ShowRecipe(){
            Console.WriteLine(name);
            foreach (string v in ingredients.Keys) {
                Console.WriteLine(v);
                foreach (int i in ingredients.Values) {
                    Console.WriteLine(i);
                }
            }
        }


    }
}
