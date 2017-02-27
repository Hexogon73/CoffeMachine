using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    abstract class MoneyReceiver
    {
        protected int sum; //сумма номиналов
        protected int num; //кол-во внесенных банкнот или монет
        private List<Money> mList = new List<Money>();

        public abstract int AddMoney(Money money);

        public int CountSum(){
            return sum;
        }

        public void ShowListMoney()
        {
            Console.WriteLine("Список номиналов монет и купюр внесенных покупателем:");
            for (int i = 0; i < mList.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, mList[i].Val);
            }
        }

        public int CountNum()
        {
            return num;
        }
    }
}
