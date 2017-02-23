using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryRecipe d1 = new DictionaryRecipe();
            d1.ShowRecipe("капучино");
            d1.ShowRecipe("эспрессо");
            d1.ShowAllRecipe();
            Console.ReadKey();
        }
    }

}
