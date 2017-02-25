using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class DictionaryRecipe
    {
        public Dictionary<string, Dictionary<string, int>> dictionary = BuildDictionary();

        private static Dictionary<string, Dictionary<string, int>> BuildDictionary()
        {
            return new Dictionary<string, Dictionary<string, int>>
            {
              {"капучино",  new Dictionary<string, int>{
                {"стакан", 1},{"кофе", 20},{"вода", 100},{"сахар", 30},{"ложка", 1},{"цена", 100}
                }
              },
              {"эспрессо",  new Dictionary<string, int>{
                {"стакан", 1},{"кофе", 30},{"вода", 100},{"сахар", 30},{"ложка", 1},{"цена", 90}
                }
              },
              {"вода",  new Dictionary<string, int>{
                {"стакан", 1},{"кофе", 0},{"вода", 100},{"сахар", 0},{"ложка", 0},{"цена", 15}
                }
              },
              {"стакан",  new Dictionary<string, int>{
                {"стакан", 1},{"кофе", 0},{"вода", 0},{"сахар", 0},{"ложка", 0},{"цена", 10}
                }
              }
            };
        }

        public int GetPrice(string recipe){
            int price;
            if (dictionary.ContainsKey(recipe))
            {
                Console.WriteLine("* " + recipe + " *");
                foreach (var v in dictionary[recipe])
                {
                    if (v.Key == "цена")
                    {
                        Console.WriteLine("{0}:\t {1}", v.Key, v.Value);
                        price = v.Value;
                        return price;
                    }
                } 
            }
            else
            {
                Console.WriteLine("рецепт '{0}' не обнаружен", recipe);
                price = -1;
                return price;
            }
            return -1;
        }

        public void GetAllPrice() {
            foreach (var v in dictionary)
            {
                Console.WriteLine("* " + v.Key + " *");
                foreach (var k in dictionary[v.Key])
                {
                    if (k.Key=="цена")
                    Console.WriteLine("{0}:\t {1}", k.Key, k.Value);
                }
            }
        }

        public void ShowAllRecipe()
        {
            Console.WriteLine("Список рецептов:");
            foreach (var v in dictionary)
            {
                ShowRecipe(v.Key);
            }
        }

        public bool ShowRecipe(string recipe)
        {
            if (dictionary.ContainsKey(recipe))
            {
                    Console.WriteLine("* " + recipe + " *");
                    Console.WriteLine("{0}, {1}", "ингредиент", "количество");
                    foreach (var v in dictionary[recipe])
                    {
                        Console.WriteLine("{0}:\t {1}", v.Key, v.Value);
                    }
                    return true;
            }
            else
            {
                Console.WriteLine("рецепт '{0}' не обнаружен",recipe);
                return false;
            }

        }

        public void ShowRecipeEnoughMoney(int money)
        {
            Console.WriteLine("внесенной суммы " + money + " хватет на:");
            foreach (var v in dictionary)
            {
                //TODO: сравнение цены всех рецептов с внесенной суммой и вывод тех которые <= 
                //if(){
                //}
                ShowRecipe(v.Key);
            }
        }
    }
}