using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class MoneyReceiver
    {
        public int sum; //сумма номиналов
        protected int num; //кол-во внесенных банкнот и монет
        List<Money> mList = new List<Money>();

        public virtual int AddMoney(Money money)
        {
            mList.Add(money);
            sum += money.Val;
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

        public void ShowSumMoney()
        {
            int sum = mList.Sum(x => x.Val);
            Console.WriteLine("Сумма номиналов монет и банкнот в системе: {0}", sum);
        }

        public void ShowNumberMoney()
        {
            foreach (Money m in mList)
            {
                num = mList.Count();
            }
            Console.WriteLine("Количество монет и банкнот в системе: {0}", num);
        }

        public int GetSum(){
            return sum;
        }
    }
}
