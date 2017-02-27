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

            d1.ShowAllPrice();
            int k = d1.GetPrice("капучино");
            Console.WriteLine(k);
            d1.ShowRecipeEnoughMoney(30);
            d1.ShowRecipeEnoughMoney(90);

            Console.WriteLine("----------");
            //ResourceBase
            ResourceBase rb1 = new ResourceBase();
            rb1.GetResource("кофе");
            rb1.GetPortion("кофе", 100); rb1.GetResource("кофе");
            rb1.SetResource("кофе", 2000); rb1.GetResource("кофе");
            rb1.ShowAllResource();

            Console.WriteLine("----------");

            Manager m1 = new Manager();
            m1.PrepareOrder("капучино", d1, p1, mr1, rb1);
            m1.PrepareOrder("капучин", d1, p1, mr1, rb1);

            d1.GetRecipe("капучино");
            d1.GetRecipe("капучио");

            Console.ReadKey();
        }
    }

}
