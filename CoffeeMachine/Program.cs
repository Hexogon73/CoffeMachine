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

            Console.WriteLine("----------");

            Coint c1 = new Coint(5);
            Banknote b1 = new Banknote(100);
            Banknote b2 = new Banknote(50);
            PaymentSystem p1 = new PaymentSystem();
            MoneyReceiver mr1 = new MoneyReceiver();
            mr1.AddMoney(c1);
            mr1.AddMoney(b1);
            mr1.AddMoney(b2);
            mr1.ShowListMoney();
            mr1.ShowSumMoney();
            mr1.ShowNumberMoney();

            Console.WriteLine("----------");

            d1.GetAllPrice();
            d1.GetPrice("капучино");
            int k = d1.GetPrice("капучино");
            Console.WriteLine(k);

            Console.WriteLine("----------");

            Manager m1 = new Manager();
            m1.PrepareOrder("капучино", d1, p1, mr1);
            m1.PrepareOrder("капучин", d1, p1, mr1);

            Console.WriteLine("----------");

            Console.ReadKey();
        }
    }

}
