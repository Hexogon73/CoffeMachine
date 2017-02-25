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
            //d1.ShowRecipe("капучино");
            //d1.ShowRecipe("эспрессо");
            //d1.ShowAllRecipe();

            Console.WriteLine("----------");

            Coint c1 = new Coint(5);
            Banknote b1 = new Banknote(100);
            Banknote b2 = new Banknote(50);
            PaymentSystem p1 = new PaymentSystem();
            p1.SetMoney(c1);
            p1.SetMoney(b1);
            p1.SetMoney(b2);
            p1.ShowListMoney();
            p1.ShowSumMoney();
            p1.ShowNumberMoney();
            Console.ReadKey();
        }
    }

}
